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
    public class SaleHistoryRepository : IRepository<SaleHistoryDetails>
    {
        private IDbConnection dbConnection = null;

        public SaleHistoryRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool Add(SaleHistoryDetails historydata)
        {
            var result = false;
            try
            {
                string sql = string.Format("insert into salehistory (datesale, originaltotal, discount, totalsale, payment_mode, username, cardno, cardreference, guid, balanceamt) " +
                                            "value ('{0}', {1}, {2}, {3}, {4}, '{5}', '{6}', '{7}','{8}', {9})",
                                            historydata.datesale.ToString("yyyy-MM-dd HH:mm:ss"),
                                            historydata.originaltotal,
                                            historydata.discount,
                                            historydata.totalsale,
                                            historydata.payment_mode,
                                            historydata.username,
                                            historydata.cardno,
                                            historydata.cardreference,
                                            historydata.guid,
                                            historydata.balanceamt
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql);
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
            throw new NotImplementedException();
        }

        public List<SaleHistoryDetails> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<SaleHistoryDetails>("SELECT * FROM salehistory;");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<SaleHistoryDetails> GetbyNowDate()
        {
            try
            {
                var queryResult = dbConnection.Query<SaleHistoryDetails>("select * from salehistory where date(datesale) = date(NOW())");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<SaleHistoryDetails> Getbymonth(int selectedmonth)
        {
            try
            {
                var queryResult = dbConnection.Query<SaleHistoryDetails>("select * from salehistory where month(datesale) = " + selectedmonth);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SaleHistoryDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SaleHistoryDetails GetByGUID(string guid)
        {
            try
            {
                return dbConnection.Query<SaleHistoryDetails>("SELECT * FROM salehistory WHERE guid = '" + guid +"';").FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<SaleHistoryDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }


        public bool Update(SaleHistoryDetails entity)
        {
            throw new NotImplementedException();
        }

        public List<SaleHistoryDetails> Search(SearchHistoryFilter filter)
        {
            var query_1 = "SELECT * FROM salehistory WHERE ";
            var query_2 = "payment_mode = {0}";
            var query_3 = "DATE(datesale) BETWEEN '{0}' and '{1}'";

            try
            {
                if (filter != null)
                {
                    string searchParam = string.Empty;

                    if (filter.payment_mode.HasValue && filter.payment_mode.Value != -1)
                    {
                        searchParam = string.Format(query_2, filter.payment_mode.Value);
                    }

                    if(filter.dateFrom.HasValue && filter.dateTo.HasValue)
                    {
                        var q = string.Format(query_3, filter.dateFrom.Value.ToString("yyyy-MM-dd"), filter.dateTo.Value.ToString("yyyy-MM-dd"));

                        if (string.IsNullOrEmpty(searchParam))
                        {
                            searchParam = q;
                        }
                        else
                        {
                            searchParam += " AND " + q;
                        }
                    }

                    return dbConnection.Query<SaleHistoryDetails>(query_1 + searchParam + ";").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
