namespace AppShopOnline.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerpage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerpage);
        //public int TotalPages => (int)Math.Celing((deciml)TotalItems / ItemsPerpage);
    }
}
