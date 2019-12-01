using MySql.Data.MySqlClient;
using POSsystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSsystem.Properties;
using POSsystem.Model.Database;
using POSsystem.Common;

namespace POSsystem.Repository
{
    public class ProductCategoryRepository : IRepository<ProductCategory>
    {
        private IDbConnection dbConnection = null;

        public ProductCategoryRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }
        public bool Add(ProductCategory prodcat)
        {
            {
                var result = false;
                try
                {
                    string sql = string.Format("insert into product_category (category_name, remark ) values ('{0}', '{1}')",
                                                prodcat.category_name,
                                                prodcat.remark
                                                );
                    var count = dbConnection.Execute(sql, prodcat);
                    result = count > 0;
                }
                catch (Exception ex)
                {
                    Logger.Log(ex, true);
                }

                return result;
            }
        }

        public bool Delete(int id)
        {
            var result = false;
            try
            {
                string sql = string.Format("DELETE FROM product_category WHERE ID = @id");
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, new { Id = id });
                return count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public List<ProductCategory> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<ProductCategory>("SELECT * FROM product_category order by category_name");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
                return null;
            }
        }

        public ProductCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategory> Search(params object[] args)
        {
            var query_1 = "SELECT * FROM product_category where ";
            var query_2 = "`category_name` LIKE '%{0}%' ;";

            try
            {
                if (args != null)
                {
                    if (args.Length == 1)
                    {
                        string searchParam;
                        var val = args[0] as string;
                        if (val != null)
                        {
                            searchParam = string.Format(query_2, val);
                            return dbConnection.Query<ProductCategory>(query_1 + searchParam).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }
            return null;
        }

        public bool Update(ProductCategory prodcat)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE product_category SET category_name = '{1}', remark = '{2}' WHERE ID = {0}",
                                            prodcat.id,
                                            prodcat.category_name,
                                            prodcat.remark);

                var count = dbConnection.Execute(sql, prodcat);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }
    }
}
