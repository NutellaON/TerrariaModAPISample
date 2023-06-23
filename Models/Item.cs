namespace TerrariaAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public decimal Price { get; set; }
        public decimal SellValue { get; set; }
        public string Tooltip { get; set; }

        public Accessory Accessory { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public ICollection<CraftingRecipe> CraftingRecipes { get; set; }
    }
}
