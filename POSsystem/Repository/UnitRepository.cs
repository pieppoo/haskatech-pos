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

        public List<UnitItem> GetAll(int itemid)
        {
            try
            {
                var queryResult = dbConnection.Query<UnitItem>("select * from ref_unit where unitcode in (select unitcode from productunits where itemid = " + itemid + " )");
                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }

        public UnitItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UnitItem> Search(params object[] args)
        {
            var query_1 = "SELECT * FROM ref_unit where ";
            var query_2 = "`description` LIKE '%{0}%' ;";

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
                            return dbConnection.Query<UnitItem>(query_1 + searchParam).ToList();
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

        public bool UpdateStock(ProductDetails stock)
        {
            throw new NotImplementedException();
        }
    }
}
