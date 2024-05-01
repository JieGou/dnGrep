using System;

namespace dnGREP.Common
{
    public enum SearchType
    {
        PlainText,
        Regex,
        XPath,
        Soundex,
        Hex
    }

    public enum FileSearchType
    {
        Asterisk,
        Regex,
        Everything
    }

    public enum FileSizeFilter
    {
        None,
        Yes,
        No
    }

    [Flags]
    public enum GrepSearchOption
    {
        None = 0,
        CaseSensitive = 1,
        Multiline = 2,
        SingleLine = 4,
        WholeWord = 8,
        StopAfterFirstMatch = 16,
        BooleanOperators = 32
    }

    public enum GrepOperation
    {
        Search,
        SearchInResults,
        Replace,
        None
    }

#pragma warning disable CA1069
    public enum FileDateFilter
    {
        None = 0,
        All = 0,
        Modified,
        Created
    }
#pragma warning restore CA1069

#pragma warning disable CA1069
    public enum FileTimeRange
    {
        None = 0,
        All = 0,
        Dates,
        Minutes,
        Hours,
        Days,
        Weeks,
        Months,
        Years
    }
#pragma warning restore CA1069

    public enum OverwriteFile
    {
        Yes,
        No,
        Prompt
    }

    public enum SortType
    {
        FileNameOnly,
        FileTypeAndName,
        FileNameDepthFirst,
        FileNameBreadthFirst,
        Size,
        Date,
        MatchCount,
        ReadOnly,
    }

    public enum ReportMode
    {
        FullLine,
        Matches,
        Groups
    }

    public enum UniqueScope
    {
        PerFile,
        Global
    }

    public enum PdfNumberType
    {
        LineNumber,
        PageNumber
    }

    /// <summary>
    /// MRU (Most Recently Used) 类型
    /// </summary>
    public enum MRUType
    {
        /// <summary>
        /// 文件夹
        /// </summary>
        SearchPath,
        /// <summary>
        /// 匹配文件名
        /// </summary>
        IncludePattern,
        /// <summary>
        /// 排除文件名
        /// </summary>
        ExcludePattern,
        /// <summary>
        /// 搜索
        /// </summary>
        SearchFor,
        /// <summary>
        /// 替换为
        /// </summary>
        ReplaceWith,
    }

    public enum FootnoteRefType
    {
        None,
        Superscript,
        Character,
        Parenthesis,
    }

    public enum CommentRefType
    {
        None,
        Subscript,
        Parenthesis
    }

    public enum HeaderFooterPosition
    {
        SectionStart,
        DocumentEnd
    }

    public enum NavigationToolsPosition
    {
        Above = 0,
        TopLeft,
        TopCenter,
        TopRight,
        BottomLeft,
        BottomCenter,
        BottomRight,
        LeftTop,
        LeftCenter,
        LeftBottom,
        RightTop,
        RightCenter,
        RightBottom,
    }

    public enum ToolSize
    {
        Small = 0,
        Medium = 1,
        Large = 2,
    }

}
