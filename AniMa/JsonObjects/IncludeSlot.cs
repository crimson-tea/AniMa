namespace JsonObjects;

public class IncludeSlot
{
    public string id { get; set; }
    public Genre genre { get; set; }
    public string title { get; set; }
    public string content { get; set; }
    public Season[] seasons { get; set; }
    public Orderedseason[] orderedSeasons { get; set; }
    public string[] copyrights { get; set; }
    public Label label { get; set; }
    public string version { get; set; }
    public int imageUpdatedAt { get; set; }
    public string programOrder { get; set; }
    public Sharedlink sharedLink { get; set; }
    public Thumbcomponent thumbComponent { get; set; }
    public Thumbportraitcomponent thumbPortraitComponent { get; set; }
    public int[] onDemandTypes { get; set; }
    public string freeBenefitTag { get; set; }
    public int contentPattern { get; set; }
}

public class Genre
{
    public string id { get; set; }
    public string name { get; set; }
    public Subgenre[] subGenres { get; set; }
}

public class Subgenre
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Label
{
    public bool free { get; set; }
    public bool newest { get; set; }
}

public class Sharedlink
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string google { get; set; }
    public string line { get; set; }
    public string copy { get; set; }
    public string instagram { get; set; }
}

public class Thumbcomponent
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public class Thumbportraitcomponent
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public class Season
{
    public string id { get; set; }
    public int sequence { get; set; }
    public string name { get; set; }
    public Thumbcomponent1 thumbComponent { get; set; }
    public Episodegroup[] episodeGroups { get; set; }
    public int order { get; set; }
}

public class Thumbcomponent1
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public class Episodegroup
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Orderedseason
{
    public string id { get; set; }
    public int sequence { get; set; }
    public string name { get; set; }
    public Thumbcomponent2 thumbComponent { get; set; }
    public Episodegroup1[] episodeGroups { get; set; }
    public int order { get; set; }
}

public class Thumbcomponent2
{
    public string urlPrefix { get; set; }
    public string filename { get; set; }
    public string query { get; set; }
    public string extension { get; set; }
}

public class Episodegroup1
{
    public string id { get; set; }
    public string name { get; set; }
}
