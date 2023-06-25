using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class CategoryModel
    {
        private KShopDBContext context = null;
        public CategoryModel()
        {
            context = new KShopDBContext();
        }

        public List<Category> ListAll()
        {
            var listCategory = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return listCategory;
        }
    }
}
