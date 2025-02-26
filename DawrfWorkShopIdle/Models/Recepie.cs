using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.DataProvider;

namespace DawrfWorkShopIdle.Models
{
    class Recepie
    {
      
            public int Id { get; set; }
            public int ProductId { get; set; }   
            public Products Product { get; set; }

        public double WorkTime { get; set; }


        public List<MaterialRequirement> MaterialsRequired { get; set; }
        

        public class MaterialRequirement
        {
            public int MaterialId { get; set; }
            public Products Material { get; set; } 
            public int Quantity { get; set; }  
        }
    }
}
