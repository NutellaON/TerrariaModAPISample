namespace TerrariaAPI.Models
{
    public class CraftingRecipeMaterials
    {
        public int RecipeId { get; set; }
        public int MaterialItemId { get; set; }
        public int MaterialQuantity { get; set; }
        public CraftingRecipe CraftingRecipe { get; set; }
        public Item MaterialItem { get; set; }
    }
}
