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
                string sql = string.Format("insert into purchase_item (itemid, purchase_qty, purchase_unit, purchase_price) value ({0}, {1}, '{2}', {3})",
                                            purchaseitem.itemid,
                                            purchaseitem.purchase_qty,
                                            purchaseitem.purchase_unit,
                                            purchaseitem.purchase_price
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, purchaseitem);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool AddwithStock(PurchaseDetails purchaseitem, int prodstock)
        {
            var result = false;
            if (dbConnection.State != ConnectionState.Open)
            {
                dbConnection.Close();
                dbConnection.Open();
            }
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: insert new purchase data
                    string sql = string.Format("insert into purchase_item (itemid, purchase_qty, purchase_unit, purchase_price) value ({0}, {1}, '{2}', {3})",
                                            purchaseitem.itemid,
                                            purchaseitem.purchase_qty,
                                            purchaseitem.purchase_unit,
                                            purchaseitem.purchase_price
                                            );

                    var count = dbConnection.Execute(sql);
                    var firstResult = count > 0;

                    if (firstResult)
                    {
                        //step 2: update stock
                        string sql2 = string.Format("update item set stock = stock + {0} where id = {1}",
                                                    prodstock,
                                                    purchaseitem.itemid);
                        var count2 = dbConnection.Execute(sql2);
                        result = count2 > 0;

                        tran.Commit();
                        return result;
                    }
                    else
                        return firstResult;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Logger.Log(ex, true);
                    return result;
                }
            }
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
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool deletewithstock(int id, int itemid, int prodstock)
        {
            var result = false;
            if (dbConnection.State != ConnectionState.Open)
            {
                dbConnection.Close();
                dbConnection.Open();
            }
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: delete purchase data
                    string sql = string.Format("DELETE FROM purchase_item WHERE ID = {0}",
                                            id
                                            );

                    var count = dbConnection.Execute(sql);
                    var firstResult = count > 0;

                    if (firstResult)
                    {
                        
                        //step 2: update stock
                        string sql2 = string.Format("update item set stock = stock - {0} where id = {1}",
                                                    prodstock,
                                                    itemid);
                        var count2 = dbConnection.Execute(sql2);
                        result = count2 > 0;

                        tran.Commit();
                        return result;
                    }
                    else
                        return firstResult;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Logger.Log(ex, true);
                    return result;
                }

        }
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
                Logger.Log(ex, true);

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
                Logger.Log(ex, true);
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
                Logger.Log(ex, true);
            }

            return result;
        }


    }
}

