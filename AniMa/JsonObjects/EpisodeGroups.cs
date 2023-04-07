namespace AniMa.JsonObjects;


public class EpisodeGroups
{
    public Episodegroupcontent[] episodeGroupContents { get; set; }
}

public class Episodegroupcontent
{
    public string id { get; set; }
    public Thumbcomponent thumbComponent { get; set; }
    public Episode episode { get; set; }
    public int type { get; set; }
    public Video video { get; set; }
    public Info info { get; set; }
}

public class Video
{
    public Term[] terms { get; set; }
    public int broadcastRegionPolicy { get; set; }
    public int releaseYear { get; set; }
}

