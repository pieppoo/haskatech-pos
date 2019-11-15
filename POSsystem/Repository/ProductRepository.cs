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



namespace POSsystem.Repository
{
    public class ProductRepository : IRepository<ProductDetails>
    {
        private IDbConnection dbConnection = null;

        public ProductRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(ProductDetails product)
        {
            var result = false;
            try
            {
                string sql = string.Format("insert into item (brand_id, name, prod_catetogry ) values ({0}, '{1}', {2})",
                                            product.brand_id,
                                            product.name,
                                            product.prod_catetogry
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, product);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public bool Delete(int id)
        {
            var result = false;
            try
            {
                string sql = string.Format("DELETE FROM item WHERE ID = @id");
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, new { Id = id });
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public List<ProductDetails> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<ProductDetails>("SELECT * FROM item;");
                
                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductDetails> GetAll(int brandid)
        {
            try
            {
                var queryResult = dbConnection.Query<ProductDetails>("SELECT * FROM item where brand_id = " + brandid);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductDetails GetById(int id)
        {
            try
            {
                var queryResult = dbConnection.Query<ProductDetails>("SELECT * FROM item where id = " + id);

                return queryResult.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public List<ProductDetails> Search(params object[] args)
        {
            var query_1 = "SELECT * FROM item WHERE ";
            var query_2 = "`name` LIKE '%{0}%' ;";
            var query_3 = "brand_id = {0};";

            try
            {
                if(args != null)
                {
                    if(args.Length == 1)
                    {
                        string searchParam;
                        var val = args[0] as string;
                        if(val != null)
                        {
                            searchParam = string.Format(query_2, val);
                        }
                        else
                        {
                            searchParam = string.Format(query_3, Convert.ToInt32(args[0]));
                        }

                        return dbConnection.Query<ProductDetails>(query_1 + searchParam).ToList();
                    }
                    else
                    {
                        var q2 = string.Format(query_2, args[0] as string).Replace(";", "");
                        var q3 = string.Format(query_3, Convert.ToInt32(args[1]));
                        return dbConnection.Query<ProductDetails>(query_1 + string.Join(" AND ", q2, q3)).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<ProductDetails> SearchProd(string prodname, int brandid, int catid)
        {
            try
            {
                string query;

                if (prodname.Length != 0 && brandid != 0 && catid != 0) // all have value
                {
                    query = "SELECT * FROM item where name LIKE '%" + prodname + "%' and brand_id = " + brandid + " and prod_catetogry = " + catid;
                }
                else if (prodname.Length == 0 && brandid != 0 && catid != 0) // name empty but brand and category have 
                {
                    query = "SELECT * FROM item where brand_id = " + brandid + " and prod_catetogry = " + catid;
                }
                else if (prodname.Length != 0 && brandid == 0 && catid != 0) // brandid empty but name and category have
                {
                    query = "SELECT * FROM item where name LIKE '%" + prodname + "%' and prod_catetogry = " + catid;
                }
                else if (prodname.Length != 0 && brandid != 0 && catid == 0) // Category empty but name and brandid have
                {
                    query = "SELECT * FROM item where name LIKE '%" + prodname + "%' and brand_id = " + brandid;
                }
                else if (prodname.Length != 0 && brandid == 0 && catid == 0) // brandid and category empty but name have
                {
                    query = "SELECT * FROM item where name LIKE'%" + prodname + "%'";
                }
                else if (prodname.Length == 0 && brandid != 0 && catid == 0) // name and category empty but brandid have
                {
                    query = "SELECT * FROM item where brand_id = " + brandid;
                }
                else  // name and brandid empty but category have
                {
                    query = "SELECT * FROM item where prod_catetogry = " + catid;
                }

                return dbConnection.Query<ProductDetails>(query).ToList();
                //return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public bool Update(ProductDetails product)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE item SET name = '{1}', brand_id = {2}, prod_catetogry = {3} WHERE ID = {0}",
                                            product.id,
                                            product.name,
                                            product.brand_id,
                                            product.prod_catetogry);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, product);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        //public bool Update3items(ProductDetails product)
        //{
        //    var result = false;
        //    try
        //    {
        //        string sql = string.Format("UPDATE item SET name = '{1}', brand_id = {2}, qty_pcs_in_container = {3} WHERE ID = {0}",
        //                                    product.id,
        //                                    product.name,
        //                                    product.brand_id,
        //                                    product.qty_pcs_in_container);
                                            
        //        Console.WriteLine(sql);

        //        var count = dbConnection.Execute(sql, product);
        //        result = count > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return result;
        //}

        public bool updateproductstock(ProductDetails product)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE item SET Stock = {1} WHERE ID = {0}",
                                            product.id,
                                            product.Stock);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, product);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public bool UpdateProductUnit(int itemid, string yesRelate)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE item SET UnitRelated = '{1}' WHERE ID = {0}",
                                            itemid,
                                            yesRelate);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

    }
}
