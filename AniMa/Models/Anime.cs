using MemoryPack;
using System;

namespace AniMa.Models;

[MemoryPackable]
public partial record Anime
{
    [MemoryPackConstructor]
    public Anime() { }
    [MemoryPackOrder(0)]
    public string Title { get; set; }

    [MemoryPackOrder(1)]
    public int CurrentStory { get; set; }

    [MemoryPackOrder(3)]
    public DayOfWeek UpdateDayOfWeek { get; private set; }

    [MemoryPackOrder(4)]
    public TimeSpan UpdateTime { get; private set; }

    [MemoryPackOrder(5)]
    public DateTime FirstEpisodeRelease { get; set; }

    [MemoryPackOrder(6)]
    public bool IsComplete { get; set; }

    [MemoryPackOrder(7)]
    public string BaseUrl { get; private set; }

    [MemoryPackOrder(9)]
    public int Year { get; set; }

    [MemoryPackIgnore]
    public string Url => $"{BaseUrl}{CurrentStory}";

    [MemoryPackIgnore]
    public DateTime LatestUpdate => FirstEpisodeRelease.AddDays((CurrentStory - 1) * 7);

    /// <summary>
    /// 一時間未満をを切り捨てた次回更新までの残り時間
    /// </summary>
    [MemoryPackIgnore]
    public TimeSpan RemainingTimeUntilNextUpdate
    {
        get
        {
            return CalcRemaining(DateTime.Now, LatestUpdate);

            static TimeSpan CalcRemaining(DateTime now, DateTime latestUpdate)
            {
                var nextUpdate = latestUpdate.Add(new TimeSpan(7, 0, 0, 0));
                var left = nextUpdate - DateTime.Today;
                var hour = ((now.Ticks + TimeSpan.TicksPerHour - 1) % TimeSpan.TicksPerDay) / TimeSpan.TicksPerHour;
                return left + new TimeSpan(24 - (int)hour, 0, 0);
            }
        }
    }

    [MemoryPackIgnore]
    public bool IsStreamingNow => TimeSpan.Zero <= RemainingTimeUntilNextUpdate && RemainingTimeUntilNextUpdate < new TimeSpan(7, 0, 0, 0);

    public string GetSubItemString(int index) => index switch
    {
        0 => Title,
        1 => CurrentStory.ToString(),
        2 => LatestUpdate.ToString("D"),
        3 => RemainingTimeUntilNextUpdate.ToString((RemainingTimeUntilNextUpdate < TimeSpan.Zero ? @"\-" : "") + @"d\日hh\時\間"),
        4 => Year.ToString(),
        _ => ""
    };

    public static Anime Complete(Anime anime) => anime with { IsComplete = !anime.IsComplete };
    public static Anime NextStory(Anime anime) => anime with { CurrentStory = anime.CurrentStory + 1 };

    /// <summary>
    /// 初回登録時
    /// </summary>
    public Anime(string title, string url, int latestNumber, int leftDays, TimeSpan updateTime, int year)
    {
        Title = title;
        BaseUrl = url;
        CurrentStory = latestNumber;
        UpdateTime = updateTime;
        Year = year;

        DateTime latestUpdate = DateTime.Today.AddDays(-(6 - leftDays));
        FirstEpisodeRelease = latestUpdate.AddDays(-(CurrentStory - 1) * 7);
    }
}
