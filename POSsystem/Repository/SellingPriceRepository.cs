﻿using MySql.Data.MySqlClient;
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
                string sql = string.Format("insert into selling_price (item_id, sell_qty, sell_unit, sell_price, Barcodeno, purchaseid ) values ({0}, {1}, '{2}', {3}, '{4}', {5})",
                                            sellingPrice.item_id,
                                            sellingPrice.sell_qty,
                                            sellingPrice.sell_unit,
                                            sellingPrice.sell_price,
                                            sellingPrice.Barcodeno,
                                            sellingPrice.purchaseid
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, sellingPrice);
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
                string sql = string.Format("DELETE FROM selling_price WHERE ID = @id");
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

        public List<SellingPriceDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SellingPriceDetails> GetAll(int purchaseid)
        {
            try
            {
                var queryResult = dbConnection.Query<SellingPriceDetails>("SELECT * from selling_price where purchaseid = " + purchaseid);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
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
                                           sellingPrice.Barcodeno);

                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, sellingPrice);
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

