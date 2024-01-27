using MemoryPack;
using System;
using System.Linq;

namespace AniMa.Models;

[MemoryPackable]
public partial record Anime
{
    [MemoryPackConstructor]
    public Anime() { }
    [MemoryPackOrder(0)]
    public string Title { get; set; }

    [MemoryPackOrder(1)]
    public int NumberOfEpisodes { get; set; }

    [MemoryPackOrder(2)]
    public DateTime StartAt { get; set; }

    [MemoryPackOrder(3)]
    public bool IsComplete { get; set; }

    [MemoryPackOrder(4)]
    public string WatchId { get; private set; }

    [MemoryPackOrder(9)]
    public int Year { get; set; }

    [MemoryPackIgnore]
    public string URL => $"https://abema.tv/video/episode/{WatchId}_p{NumberOfEpisodes}";

    /// <summary>
    /// 一時間未満をを切り捨てた次回更新までの残り時間
    /// </summary>
    [MemoryPackIgnore]
    public TimeSpan RemainingTimeUntilNextUpdate
    {
        get
        {
            return CalcRemaining(DateTime.Now, StartAt);

            static TimeSpan CalcRemaining(DateTime now, DateTime latestUpdate)
            {
                var nextUpdate = latestUpdate.Add(new TimeSpan(7, 0, 0, 0));

                var f = -new TimeSpan(now.Ticks % TimeSpan.TicksPerHour);
                f += f.Ticks != 0 ? new TimeSpan(TimeSpan.TicksPerHour) : TimeSpan.Zero;

                return nextUpdate - now.Add(f);
            }
        }
    }

    [MemoryPackIgnore]
    public bool IsStreamingNow => TimeSpan.Zero <= RemainingTimeUntilNextUpdate && RemainingTimeUntilNextUpdate < new TimeSpan(7, 0, 0, 0);

    public string GetSubItemString(int index) => index switch
    {
        0 => Title,
        1 => NumberOfEpisodes.ToString(),
        2 => StartAt.ToString("D"),
        3 => RemainingTimeUntilNextUpdate.ToString((RemainingTimeUntilNextUpdate < TimeSpan.Zero ? @"\-" : "") + @"d\日hh\時\間"),
        4 => Year.ToString(),
        _ => ""
    };

    public static Anime Complete(Anime anime) => anime with { IsComplete = !anime.IsComplete };
    public static Anime NextStory(Anime anime) => anime with { NumberOfEpisodes = anime.NumberOfEpisodes + 1, StartAt = anime.StartAt.AddDays(7) };

    /// <summary>
    /// 初回登録時
    /// </summary>
    public Anime(string title, string url, int latestNumber, int leftDays, int year)
    {
        string watchIdSegment = url.Split('/').Last();
        WatchId = watchIdSegment[..watchIdSegment.LastIndexOf("_p")];
        Title = title;
        NumberOfEpisodes = latestNumber;
        StartAt = DateTime.Today.AddDays(leftDays - 6);
        Year = year;
    }

    public Anime(string titie, string watchIdSegment, DateTime startAt, int numberOfSeries)
    {
        Title = titie;
        string watchId = watchIdSegment[..watchIdSegment.LastIndexOf("_p")];
        WatchId = watchId;
        NumberOfEpisodes = numberOfSeries;
        StartAt = startAt;
        Year = startAt.AddDays(-(numberOfSeries - 1) * 7).Year;
    }

    public static Anime CreateFirstStory(string title, string url, int year)
    {
        string watchIdSegment = url.Split('/').Last();
        return new Anime(title, watchIdSegment, new DateTime(year, 1, 1), 1);
    }
}
