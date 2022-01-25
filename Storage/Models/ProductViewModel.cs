using System.ComponentModel;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        [DisplayName("Inventory Value")]
        public int InventoryValue { get; set; }
    }
}
