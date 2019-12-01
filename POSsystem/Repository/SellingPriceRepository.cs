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
using POSsystem.Common;

namespace POSsystem.Repository
{
    public class SellingPriceRepository : IRepository<SellingPriceDetails>
    {
        private IDbConnection dbConnection = null;

        public SellingPriceRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(SellingPriceDetails sellingPrice)
        {
            var result = false;
            try
            {
                string sql = string.Format("insert into selling_price (item_id, sell_qty, sell_unit, sell_price, Barcodeno ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                            sellingPrice.item_id,
                                            sellingPrice.sell_qty,
                                            sellingPrice.sell_unit,
                                            sellingPrice.sell_price,
                                            sellingPrice.Barcodeno
                                            );

                var count = dbConnection.Execute(sql, sellingPrice);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool Delete(int id)
        {
            var result = false;
            try
            {
                string sql = string.Format("DELETE FROM selling_price WHERE ID = @id");

                var count = dbConnection.Execute(sql, new { Id = id });
                return count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public List<SellingPriceDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SellingPriceDetails> GetAll(int itemid)
        {
            try
            {
                var queryResult = dbConnection.Query<SellingPriceDetails>("SELECT * from selling_price where item_id = " + itemid);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);

            }
            return null;
        }

        public SellingPriceDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SellingPriceDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(SellingPriceDetails sellingPrice)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE selling_price SET sell_unit = '{1}', sell_price = {2}, Barcodeno = {3} WHERE ID = {0}",
                                           sellingPrice.id,
                                           sellingPrice.sell_unit,
                                           sellingPrice.sell_price,
                                           string.IsNullOrWhiteSpace(sellingPrice.Barcodeno) ? "null" : "'" + sellingPrice.Barcodeno + "'");

                var count = dbConnection.Execute(sql, sellingPrice);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }


    }
}

