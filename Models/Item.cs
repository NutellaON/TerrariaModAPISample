namespace TerrariaAPI.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public decimal Price { get; set; }
        public decimal SellValue { get; set; }
        public int StackSize { get; set; }
        public int MaxStack { get; set; }
        public string UseAction { get; set; }
        public string UseAnimation { get; set; }
        public int UseTime { get; set; }
        public string Tooltip { get; set; }
    }
}
