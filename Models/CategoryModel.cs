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

        public int Create(string name, string alias, int? parentId, int? order, bool? status)
        {
            var parameters = new object[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Alias", alias),
                new SqlParameter("@ParentID", parentId),
                new SqlParameter("@Order", order),
                new SqlParameter("@Status", status)
            };

            int res = context.Database.ExecuteSqlCommand("Sq_Categoty_Insert @Name,@Alias,@ParentID,@Order,@Status", parameters);
            return res;
        }

    }
}
