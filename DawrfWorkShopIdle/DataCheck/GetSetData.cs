using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawrfWorkShopIdle.DataTransfer
{
    class GetSetData
    {
        public static string ConnectionString = @"Server=.\SQLEXPRESS;Database=DwarfWorkShop;Trusted_Connection=True;";



        public static string GetConnectionString()
        {
            return ConnectionString;
        }

        
    }
}