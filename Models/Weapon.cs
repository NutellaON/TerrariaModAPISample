namespace TerrariaAPI.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Damage { get; set; }
        public decimal AttackSpeed { get; set; }
        public Item Item { get; set; }
    }
}
