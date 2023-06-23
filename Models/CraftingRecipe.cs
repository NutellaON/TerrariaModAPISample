namespace TerrariaAPI.Models
{
    public class CraftingRecipe
    {
        public int Id { get; set; }
        public int ResultItemId { get; set; }
        public int ResultQuantity { get; set; }
        public Item ResultItem { get; set; }
        public ICollection<CraftingRecipeMaterials> Materials { get; set; }
    }
}
