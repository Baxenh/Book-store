using System.Drawing.Printing;

namespace AppShopOnline.Models
{
    public class FilterData
    {
        public List<string> PriceRanges { get; set; }
        public List<string> Colors { get; set; }
        public List<string> SizeRanges { get; set; }
        public object Sizes { get; internal set; }
    }         

   
}