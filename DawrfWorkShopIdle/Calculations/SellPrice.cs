﻿using DawrfWorkShopIdle.Models;

namespace DawrfWorkShopIdle.Calculations
{
    class SellPrice
    {
        public static void SellPricePartOne()
        {
            using (var mydb = new MyDbContext())
            {

                var everyProducts = mydb.Products.ToList();

                foreach (var product in everyProducts)
                {
                    if (product.IsBar)
                    {
                        continue; // ensure that ore price is not changed
                    }
                    double cost = 0;
                    var recipe = mydb.Recepie.FirstOrDefault(p => p.Id == product.RecipeId);

                    if (recipe == null)
                    {
                        continue;
                    }
                    foreach (var material in recipe.MaterialsRequired)
                    {
                        if (material.Material.IsBar)
                        {
                            var barRecipeId = mydb.Recepie.FirstOrDefault(r => r.Id == material.Material.RecipeId);

                            if (barRecipeId != null)
                            {
                                var oreMaterial = barRecipeId.MaterialsRequired.FirstOrDefault();

                                if (oreMaterial != null)
                                {
                                    var orePrice = mydb.Products.FirstOrDefault(p => p.Id == oreMaterial.MaterialId).Price;
                                    double barPrice = ((material.Quantity * oreMaterial.Quantity) * orePrice) * product.TimeEfficiency;

                                    cost += barPrice;
                                }
                            }
                        }
                        else
                        {
                            var materialProduct = mydb.Products.FirstOrDefault(p => p.Id == material.MaterialId);
                            if (materialProduct != null)
                            {
                                double materialCost = materialProduct.Price * material.Quantity;
                                cost += materialCost; // no TimeEfficiency
                            }
                        }
                    }
                product.Price = cost;
                }
            }
        }

        public static void SellPricePartTwo()
        {

            double miniumPriceControll = 0.7;
            double LowsuppleIncrease = 1.2;
            
            using (var mydb = new MyDbContext())
            {
                var everyProduct = mydb.Products.ToList();

                foreach(var product in everyProduct)
                {
                    var shopInfo = mydb.Shop.FirstOrDefault(p => p.ProductId == product.Id);
                    double supplyControll = shopInfo.Supply / shopInfo.Demand;

                    double supDem = Math.Max(miniumPriceControll, (shopInfo.Demand - shopInfo.Supply / 1000));

                    if(supplyControll < 0.2)
                    {
                        supDem *= LowsuppleIncrease;
                    }

                }
            }
        }
    }
}
