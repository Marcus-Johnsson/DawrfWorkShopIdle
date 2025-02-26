using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawrfWorkShopIdle.Models
{
    class Shop
    {
        


        public int ProductId { get; set; }

        public int Supply { get; set; }

        public int Demand { get; set; }

        private double DemandReduceRate = 0.2; 


        public Shop()
        {

        }
    }
}
