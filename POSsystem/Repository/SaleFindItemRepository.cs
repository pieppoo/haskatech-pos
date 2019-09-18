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
    class SaleFindItemRepository : IRepository<SellingPriceDetails>
    {
        private IDbConnection dbConnection = null;

        public SaleFindItemRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(SellingPriceDetails entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SellingPriceDetails GetByBarcodeNo(string barcodeno)
        {
            try
            {
                var sql = "SELECT * from selling_price where Barcodeno = '" + barcodeno + "'";
                var queryResult = dbConnection.Query<SellingPriceDetails>(sql);

                return queryResult.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }

        public List<SellingPriceDetails> GetAll(int itemid)
        {
            try
            {
                var sql = "SELECT * from selling_price where item_id = " + itemid;
                var queryResult = dbConnection.Query<SellingPriceDetails>(sql);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }


        public List<SellingPriceDetails> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<SellingPriceDetails>("SELECT * FROM selling_price;");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SellingPriceDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SellingPriceDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(SellingPriceDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
