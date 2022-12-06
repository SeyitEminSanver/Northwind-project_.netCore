using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürün listesi eklendi";
        public static string MaintenanceTime="Bakım saati";
        public static string ProductCountOfCategoryError="Kategori limiti aşıldı";
    }
}
