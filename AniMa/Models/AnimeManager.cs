using MemoryPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace AniMa.Models;

public class AnimeManager : IRedoUndo<Operation>
{
    public record UIState(bool CanUndo, bool CanRedo);

    private static readonly string s_saveFilePath = @".\save.mempack";

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
        _animes = Load(s_saveFilePath);
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
        SaveOngoing(s_saveFilePath);
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

    public void UpdateDateTime(Anime anime)
    {
        var oldAnime = _animes.FirstOrDefault(x => x.WatchId == anime.WatchId && x.NumberOfEpisodes == anime.NumberOfEpisodes);
        if (oldAnime is null) { return; }

        var newAnime = oldAnime with { StartAt = anime.StartAt };
        Replace(oldAnime, newAnime);
    }

    internal bool Exist(string watchIdSegment, int numberOfEpisodes)
    {
        var watchId = watchIdSegment[..watchIdSegment.LastIndexOf("_p")];
        return _animes.Any(x => x.WatchId == watchId && x.NumberOfEpisodes == numberOfEpisodes);
    }

    internal bool Exist(Anime anime)
    {
        return _animes.Any(x => x.WatchId == anime.WatchId && x.NumberOfEpisodes == anime.NumberOfEpisodes);
    }

    internal bool ExistByWatchId(Anime anime)
    {
        return _animes.Any(x => x.WatchId == anime.WatchId);
    }

    internal bool ExistMoreThanNumberOfEpisodes(Anime anime)
    {
        return _animes.Any(x => x.WatchId == anime.WatchId && x.NumberOfEpisodes >= anime.NumberOfEpisodes);
    }

    internal bool IsSameDateTime(Anime anime)
    {
        var registered = _animes.FirstOrDefault(x => x.WatchId == anime.WatchId && x.NumberOfEpisodes == anime.NumberOfEpisodes);
        if (registered is null) { return false; }

        return registered.StartAt == anime.StartAt;
    }

    internal Anime GetAnime(string watchId, int numberOfEpisodes)
        => _animes.FirstOrDefault(x => x.WatchId == watchId && x.NumberOfEpisodes == numberOfEpisodes);

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
