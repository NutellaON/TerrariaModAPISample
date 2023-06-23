namespace TerrariaAPI.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string AccessoryType { get; set; }
        public Item Item { get; set; }
    }
}
