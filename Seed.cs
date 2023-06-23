using TerrariaAPI.Data;
using TerrariaAPI.Models;

namespace TerrariaAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {

            var items = new Item[]
            {
                new Item { Name = "Sword", Description = "A powerful sword", Type = "Weapon", Rarity = "1", Price = 10, SellValue = 1, Tooltip = "A great item" }
            };

            dataContext.Items.AddRange(items);
            dataContext.SaveChanges();
        }
    }
}
