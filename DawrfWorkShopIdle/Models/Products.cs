using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.DataProvider;

namespace DawrfWorkShopIdle.Models
{
    class Products
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public bool IsMaterial { get; set; }

        public double Price { get; set; }

        public int LvlRequirement { get; set; }

        public List<Products> ProductsMadeFrom { get; set; }
    }
}
