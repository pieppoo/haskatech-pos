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
    public class UnitRepository : IRepository<UnitItem>
    {
        private IDbConnection dbConnection = null;

        public UnitRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(UnitItem unit)
        {
            var result = false;
            try
            {
                string sql = string.Format("INSERT INTO ref_unit (unitcode, description) VALUES ('{0}', '{1}')",
                                            unit.unitcode,
                                            unit.description);
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, unit);
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
                string sql = string.Format("DELETE FROM ref_unit WHERE ID = @id");
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

        public List<UnitItem> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<UnitItem>("select * from ref_unit");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public UnitItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UnitItem> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(UnitItem unit)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE ref_unit SET description = '{2}'  WHERE ID = '{0}'",
                                            unit.id,
                                            unit.unitcode,
                                            unit.description);
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, unit);
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
