namespace TerrariaAPI.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Defense { get; set; }
        public string SetBonus { get; set; }
        public Item Item { get; set; }
    }
}
