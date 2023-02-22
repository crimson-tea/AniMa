using AniMa.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AniMa;

/// <summary>
/// ListViewの項目の並び替えに使用するクラス
/// </summary>
public class ListViewItemComparer : IComparer
{
    private readonly Dictionary<int, SortCondition> _conditions = new();
    public enum SortOrder { Descending = -1, Ascending = 1, }

    /// <summary>
    /// ListViewItemComparerクラスのコンストラクタ
    /// </summary>
    /// <param name="column">並び替える列番号</param>
    public ListViewItemComparer(int column = 3)
    {
        _conditions.Add(column, new SortCondition(column, GetDefaultOrder(column)));
    }

    /// <summary>
    /// 既に追加されている条件なら降順昇順を切り替え、
    /// 新規の条件なら追加します。
    /// </summary>
    /// <param name="column"></param>
    public void AddOrChangePredicate(int column)
    {
        if (_conditions.TryGetValue(column, out SortCondition condition))
        {
            condition.Reverse();
        }
        else
        {
            _conditions.Add(column, new SortCondition(column, GetDefaultOrder(column)));
        }
    }

    /// <summary>
    /// 条件が一つで同じ列が指定されたとき、降順昇順を切り替えます。
    /// 条件が複数の場合は新たに条件を指定し直します。
    /// </summary>
    /// <param name="column"></param>
    internal void NewPredicateOrReverse(int column)
    {
        if (_conditions.Count == 1 && _conditions.TryGetValue(column, out SortCondition condition))
        {
            condition.Reverse();
        }
        else
        {
            _conditions.Clear();
            _conditions.Add(column, new SortCondition(column, GetDefaultOrder(column)));
        }
    }

    private SortOrder GetDefaultOrder(int column) => column switch
    {
        0 => SortOrder.Ascending,
        1 => SortOrder.Ascending,
        2 => SortOrder.Descending,
        3 => SortOrder.Ascending,
        4 => SortOrder.Ascending,
        _ => throw new ArgumentException()
    };

    enum SortType { Title, Number, LatestUpdate, TimeLeft, Year }

    public int Compare(object x, object y)
    {
        var a = (Anime)((ListViewItem)x).Tag;
        var b = (Anime)((ListViewItem)y).Tag;

        return _conditions.Select((x) => x.Value)
            .Select(x => Compare(x) * (int)x.Order)
            .FirstOrDefault(x => x != 0);

        int Compare(SortCondition condition) => (SortType)condition.Column switch
        {
            SortType.Title => a.Title.CompareTo(b.Title),
            SortType.Number => a.CurrentStory.CompareTo(b.CurrentStory),
            SortType.LatestUpdate => a.LatestUpdate.CompareTo(b.LatestUpdate),
            SortType.TimeLeft => a.RemainingTimeUntilNextUpdate.CompareTo(b.RemainingTimeUntilNextUpdate),
            SortType.Year => a.Year.CompareTo(b.Year),
            _ => throw new ArgumentException()
        };
    }

    class SortCondition
    {
        public SortCondition(int column, SortOrder order)
        {
            Column = column;
            Order = order;
        }

        public int Column { get; set; }

        public SortOrder Order { get; set; }

        public void Reverse() => Order = (SortOrder)(-(int)Order);

        public void Deconstruct(out int column, out SortOrder order) => (column, order) = (Column, Order);
    }
}
