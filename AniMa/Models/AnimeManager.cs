using MemoryPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace AniMa.Models;

internal class AnimeManager : IRedoUndo<Operation>
{
    internal record UIState(bool CanUndo, bool CanRedo);

    static readonly string saveFileMemory = @".\save.mempack";

    public RedoUndo<Operation> _redoUndo;

    public UIState Redo()
    {
        _redoUndo.Redo();
        return new(_redoUndo.CanUndo, _redoUndo.CanRedo);
    }

    public UIState Undo()
    {
        _redoUndo.Undo();
        return new(_redoUndo.CanUndo, _redoUndo.CanRedo);
    }

    public UIState Execute(Operation operation)
    {
        _redoUndo.Execute(operation);
        return new(_redoUndo.CanUndo, _redoUndo.CanRedo);
    }

    public ReadOnlyCollection<Anime> Animes => new(_animes.Where(x => x.IsComplete is false).ToList());

    private readonly List<Anime> _animes;

    public AnimeManager()
    {
        _animes = Load(saveFileMemory);
        _redoUndo = new RedoUndo<Operation>(this);
    }

    /// <summary>
    /// 保存されたファイルがある場合はファイルから読み込み、ない場合は空のリストを作成する。
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    private static List<Anime> Load(string path) => File.Exists(path) ? LoadFile(path) : new List<Anime>();

    /// <summary>
    /// アニメリストをファイルから読み込む。
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    private static List<Anime> LoadFile(string path)
    {
        var bytes = File.ReadAllBytes(path);
        return MemoryPackSerializer.Deserialize<List<Anime>>(bytes);
    }

    /// <summary>
    /// アニメリストを保存する。
    /// </summary>
    public void Save()
    {
        SaveOngoing(saveFileMemory);
    }

    ///  <summary>
    /// 視聴中のアニメリストの保存をする。
    /// </summary>
    public void SaveOngoing(string path) => SaveFile(path, _animes.Where(x => x.IsComplete is false).ToList());

    /// <summary>
    /// アニメリストをファイルに保存する。
    /// </summary>
    /// <param name="path"></param>
    /// <param name="animes"></param>
    private static void SaveFile(string path, List<Anime> animes)
    {
        var bytes = MemoryPackSerializer.Serialize(animes);
        File.WriteAllBytes(path, bytes);
    }

    public void AddAnime(Anime anime) => _animes.Add(anime);

    private void Replace(Anime oldAnime, Anime newAnime)
    {
        var index = _animes.FindIndex(0, x => ReferenceEquals(x, oldAnime));
        _animes[index] = newAnime;
    }

    /// <summary>
    /// 視聴期限内または視聴期限が切れているものなら話を進めるられる。
    /// </summary>
    /// <param name="anime"></param>
    /// <returns></returns>
    public static bool CanDone(Anime anime) => anime.RemainingTimeUntilNextUpdate < new TimeSpan(7, 0, 0, 0);

    void IRedoUndo<Operation>.ExecuteRedo(Operation operation) => (operation.OperationType switch
    {
        OperationType.Next => (Action<Anime, Anime>)Replace,
        OperationType.Complete => Replace,
        OperationType.Edit => Replace,
        _ => throw new ArgumentException(nameof(operation.OperationType)),
    })(operation.OldAnime, operation.NewAnime);

    void IRedoUndo<Operation>.ExecuteUndo(Operation operation) => (operation.OperationType switch
    {
        OperationType.Next => (Action<Anime, Anime>)Replace,
        OperationType.Complete => Replace,
        OperationType.Edit => Replace,
        _ => throw new ArgumentException(nameof(operation.OperationType)),
    })(operation.NewAnime, operation.OldAnime);

    void IRedoUndo<Operation>.SetProgress(int step) { }
}

public enum OperationType { Next, Complete, Edit, }
public record Operation(OperationType OperationType, Anime OldAnime, Anime NewAnime);
