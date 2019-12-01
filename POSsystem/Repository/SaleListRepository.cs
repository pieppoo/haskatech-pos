using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Model.Database;
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
            try
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
            catch (Exception ex)
            {
                Logger.Log(ex, true);
                return null;
            }

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
                Logger.Log(ex, true);
                return null;
            }
            
        }

        public List<DetailReportMonthly> GetReportDetail(int datesale)
        {
            try
            {
                var sqlquery = "select  saledetail.itemid as itemid, item.`name` as item_name, " +
                    "sum(case when saledetail.unitsale = item.unit_pcs Then saledetail.qtysale " +
                    "when saledetail.unitsale = item.unit_bulk then saledetail.qtysale * item.qty_pcs_in_container " +
                    "else 1 end) as totalQTY, item.qty_pcs_in_container as pcsqty, " +
                    "sum(saledetail.originaltotal) as subtotal, sum(saledetail.discount) as discount, " +
                    "sum(saledetail.totalprice) as grandtotal, " +
                    "item.unit_bulk as unit_bulk, item.unit_pcs as unit_pcs " +
                    "from saledetail join salehistory on saledetail.historyid = salehistory.id " +
                    "join item on item.id = saledetail.itemid " +
                    "where MONTH(salehistory.datesale) = " + datesale + " group by saledetail.itemid";

                var queryResult = dbConnection.Query<DetailReportMonthly>(sqlquery);

                    

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);

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
