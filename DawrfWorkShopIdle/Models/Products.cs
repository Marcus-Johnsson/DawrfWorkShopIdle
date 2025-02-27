namespace DawrfWorkShopIdle.Models
{
    class Products
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public bool IsMaterial { get; set; }

        public bool IsBar { get; set; }

        public int TimeEfficiency { get; set; } // copper 5% tin 8% iron 10% silver 15% gold 20% three material item gain 5% extra. Smelting into bars is only 5%.

        public double Price { get; set; }

        public int LvlRequirement { get; set; }

        public List<Products> ProductsMadeFrom { get; set; }
    



    }
}