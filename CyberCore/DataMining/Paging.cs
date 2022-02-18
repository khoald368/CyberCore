namespace CyberCore.DataMining
{
    public record Paging
    {
        public int PageIndex { get; init; }

        public int PageSize { get; init; }

        public string SortBy { get; init; }

        public string SortType { get; init; }
    }
}
