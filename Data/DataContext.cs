using Microsoft.EntityFrameworkCore;
using TerrariaAPI.Models;

namespace TerrariaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) 
        {
        }
        
        public DbSet<Item> Items { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<CraftingRecipe> CraftingRecipes { get; set; }
        public DbSet<CraftingRecipeMaterials> CraftingRecipeMaterials { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraftingRecipeMaterials>()
                 .HasOne(crm => crm.MaterialItem)
                 .WithMany()
                 .HasForeignKey(crm => crm.MaterialItemId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
