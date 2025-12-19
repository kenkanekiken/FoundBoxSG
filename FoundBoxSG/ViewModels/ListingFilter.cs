namespace FoundBoxSG.ViewModels
{
    public enum ListingTypeFilter { All, Found, Lost }
    public enum SortFilter { Latest, Oldest }

    public class ListingFilter
    {
        public ListingTypeFilter Type { get; set; } = ListingTypeFilter.All;
        public string? Category { get; set; } = null;  
        public SortFilter Sort { get; set; } = SortFilter.Latest;
    }
}
