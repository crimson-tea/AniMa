using MemoryPack;
using System.IO;

namespace AniMa.Models;

[MemoryPackable]
public partial class Settings
{
    public static readonly string SettingsPath = @"./settings.mempack";

    [MemoryPackOrder(0)]
    public string BrowserPath { get; set; }
    [MemoryPackOrder(1)]
    public string Argument { get; set; }
    [MemoryPackOrder(2)]
    public bool UseFilter { get; set; }

    public static readonly string DefaultBrowserPath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

    public static Settings DefaultSettings => new() { BrowserPath = DefaultBrowserPath, Argument = string.Empty };

    public static void Save(string path, Settings settings)
    {
        var bytes = MemoryPackSerializer.Serialize(settings);
        File.WriteAllBytes(path, bytes);
    }

    public static Settings Load(string path) => File.Exists(path) ? LoadFile(path) : DefaultSettings;

    /// <summary>
    /// ファイルを読み込む。
    /// ファイルの読み込みに失敗したら初期化する。
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static Settings LoadFile(string path)
    {
        var bytes = File.ReadAllBytes(path);
        try
        {
            return MemoryPackSerializer.Deserialize<Settings>(bytes);
        }
        catch (System.Exception)
        {
            return DefaultSettings;
        }
    }

    public string CreateArgument(string url) => $"{url} {Argument}";

    public bool CanOpenBrowser => string.IsNullOrWhiteSpace(OpenableBrowserPath) is false;

    public string OpenableBrowserPath => File.Exists(BrowserPath) ? BrowserPath
           : File.Exists(DefaultBrowserPath) ? DefaultBrowserPath
           : string.Empty;
}
