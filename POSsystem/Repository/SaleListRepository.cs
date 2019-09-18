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

        public bool AddMany(List<SaleItemsDetail> entity, int historyId)
        {
            var query1 = "INSERT INTO saledetail(historyid, itemid, qtysale, unitsale, priceperitem, originaltotal, discount, totalprice) VALUES ";
            var query2 = "({0}, {1}, {2}, '{3}', {4}, {5}, {6}, {7})";
            var list = new List<string>();

            foreach (var item in entity)
            {
                list.Add(string.Format(query2, 
                                       historyId, item.itemid, item.qtysale, item.unitsale, item.priceperitem, item.originaltotal, item.discount, item.totalprice));
            }

            var values = string.Join(",", list);
            var fullQuery = query1 + values;

            var result = dbConnection.Execute(fullQuery);
            return true;
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
