namespace AniMa.JsonObjects;

#pragma warning disable IDE1006 // 命名スタイル
public record ProgramObject
{
    public Program[] programs { get; set; }
    public string version { get; set; }
}

public record Program
{
    public string id { get; set; }
    public Series series { get; set; }
    public Season season { get; set; }
    public Info info { get; set; }
    public Providedinfo providedInfo { get; set; }
    public Episode episode { get; set; }
    public Credit credit { get; set; }
    public Mediastatus mediaStatus { get; set; }
    public Label label { get; set; }
    public int imageUpdatedAt { get; set; }
    public int endAt { get; set; }
    public int freeEndAt { get; set; }
    public string transcodeVersion { get; set; }
    public Sharedlink sharedLink { get; set; }
    public Viewingpoint viewingPoint { get; set; }
    public Download download { get; set; }
    public Externalcontent externalContent { get; set; }
    public int broadcastRegionPolicy { get; set; }
    public Timelinethumbcomponent timelineThumbComponent { get; set; }
    public Term[] terms { get; set; }
}

public record Series
{
    public string id { get; set; }
    public string title { get; set; }
    public Label label { get; set; }
    public Thumbcomponent thumbComponent { get; set; }
    public Thumbportraitcomponent thumbPortraitComponent { get; set; }
}

public record Label
{
    public bool free { get; set; }
}

public record Thumbcomponent
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public record Thumbportraitcomponent
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public record Season
{
    public string id { get; set; }
    public int sequence { get; set; }
    public string name { get; set; }
    public Thumbcomponent thumbComponent { get; set; }
    public int order { get; set; }
}

public record Info
{
    public int duration { get; set; }
}

public record Providedinfo
{
    public string thumbImg { get; set; }
    public string[] sceneThumbImgs { get; set; }
}

public record Episode
{
    public int number { get; set; }
    public string title { get; set; }
    public string content { get; set; }
}

public record Credit
{
    public int released { get; set; }
    public string[] casts { get; set; }
    public string[] crews { get; set; }
    public string[] copyrights { get; set; }
}

public record Mediastatus
{
}

public record Sharedlink
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string google { get; set; }
    public string line { get; set; }
    public string copy { get; set; }
    public string instagram { get; set; }
}

public record Viewingpoint
{
}

public record Download
{
    public bool enable { get; set; }
}

public record Externalcontent
{
    public Marks marks { get; set; }
}

public record Marks
{
}

public record Timelinethumbcomponent
{
    public string urlPrefix { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public record Term
{
    public int onDemandType { get; set; }
    public int endAt { get; set; }
}
#pragma warning restore IDE1006 // 命名スタイル
