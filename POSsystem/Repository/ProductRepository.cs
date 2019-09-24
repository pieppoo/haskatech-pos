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
                string sql = string.Format("insert into item (brand_id, name, stock, unit_bulk, unit_pcs, qty_pcs_in_container ) values ({0}, '{1}', {2}, '{3}', '{4}', {5})",
                                            product.brand_id,
                                            product.name,
                                            product.Stock,
                                            product.unit_bulk,
                                            product.unit_pcs,
                                            product.qty_pcs_in_container
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
            throw new NotImplementedException();
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
                        var q2 = string.Format(query_2, args[0] as string);
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

        public bool Update(ProductDetails product)
        {
            throw new NotImplementedException();
        }

        public bool Update3items(ProductDetails product)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE item SET name = '{1}', brand_id = {2}, qty_pcs_in_container = {3} WHERE ID = {0}",
                                            product.id,
                                            product.name,
                                            product.brand_id,
                                            product.qty_pcs_in_container);
                                            
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


    }
}
