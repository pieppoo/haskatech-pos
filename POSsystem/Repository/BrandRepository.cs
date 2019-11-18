using Dapper;
using MySql.Data.MySqlClient;
using POSsystem.Database;
using POSsystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace POSsystem.Repository
{
    public class BrandRepository : IRepository<Brand>
    {
        private IDbConnection dbConnection = null;

        public BrandRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(Brand brand)
        {
            var result = false;
            try
            {
                string sql = string.Format("INSERT INTO Brand (name, remark) VALUES ('{0}', '{1}')",
                                            brand.name,
                                            brand.remark);
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, brand);
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
                string sql = string.Format("DELETE FROM brand WHERE ID = @id");
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

        public List<Brand> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<Brand>("SELECT * FROM Brand order by name ");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public Brand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> Search(params object[] args)
        {
            var query_1 = "SELECT * FROM brand where ";
            var query_2 = "`name` LIKE '%{0}%' ;";

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
                            return dbConnection.Query<Brand>(query_1 + searchParam).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool Update(Brand brand)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE Brand SET name = '{1}', remark = '{2}' WHERE ID = '{0}'",
                                            brand.id,
                                            brand.name,
                                            brand.remark);
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, brand);
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
