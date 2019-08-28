using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using POSsystem.Database;
using POSsystem.Properties;

namespace POSsystem.Repository
{
    public class SaleListRepository : IRepository<SaleListDetails>
    {
        private IDbConnection dbConnection = null;

        public SaleListRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(SaleListDetails entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SaleListDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SaleListDetails> GetAll(int historyid)
        {
            try
            {
                var queryResult = dbConnection.Query<SaleListDetails>("SELECT * from saledetail where historyid = " + historyid);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }

        public SaleListDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SaleListDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(SaleListDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
