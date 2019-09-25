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
                var queryResult = dbConnection.Query<Brand>("SELECT * FROM Brand ");

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
            throw new NotImplementedException();
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
