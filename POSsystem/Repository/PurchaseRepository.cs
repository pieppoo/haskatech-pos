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
    public class PurchaseRepository : IRepository<PurchaseDetails>
    {
        private IDbConnection dbConnection = null;

        public PurchaseRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(PurchaseDetails purchaseitem)
        {
            var result = false;
            try
            {
                string sql = string.Format("insert into purchase_item (itemid, purchase_qty, purchase_unit, purchase_price, qty_pcs_in_container, pcs_unit, total_in_pcs) value ({0}, {1}, '{2}', {3}, {4}, '{5}', {6})",
                                            purchaseitem.itemid,
                                            purchaseitem.purchase_qty,
                                            purchaseitem.purchase_unit,
                                            purchaseitem.purchase_price,
                                            purchaseitem.qty_pcs_in_container,
                                            purchaseitem.pcs_unit,
                                            purchaseitem.total_in_pcs
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, purchaseitem);
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
                string sql = string.Format("DELETE FROM purchase_item WHERE ID = @id");
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

        public List<PurchaseDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PurchaseDetails> GetAll(int itemid)
        {
            try
            {
                var queryResult = dbConnection.Query<PurchaseDetails>("SELECT * from purchase_item where itemid = " + itemid);
                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return null;
        }

        public PurchaseDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(PurchaseDetails purchase)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE purchase_item SET purchase_qty = {1}, purchase_unit = '{2}', purchase_price = {3}, pcs_unit = '{4}', qty_pcs_in_container = {5}, total_in_pcs = {6} WHERE ID = {0}",
                                           purchase.id,
                                           purchase.purchase_qty,
                                           purchase.purchase_unit,
                                           purchase.purchase_price,
                                           purchase.pcs_unit,
                                           purchase.qty_pcs_in_container,
                                           purchase.total_in_pcs);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, purchase);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public bool Updatestock(PurchaseDetails purchase)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE purchase_item SET total_in_pcs = {1}  WHERE ID = {0}",
                                           purchase.id,
                                           purchase.total_in_pcs);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, purchase);
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

