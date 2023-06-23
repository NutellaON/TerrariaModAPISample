namespace TerrariaAPI.Models
{
    public class CraftingRecipeMaterials
    {
        public int Id { get; set; }
        public int MaterialItemId { get; set; }
        public int MaterialQuantity { get; set; }
        public int CraftingRecipeId { get; set; }
        public CraftingRecipe CraftingRecipe { get; set; }
        public Item MaterialItem { get; set; }
    }
}
