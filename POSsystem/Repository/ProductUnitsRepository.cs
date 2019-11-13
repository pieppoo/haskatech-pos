using MySql.Data.MySqlClient;
using POSsystem.Database;
using POSsystem.Model.Database;
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
    public class ProductUnitsRepository : IRepository<ProductUnitsDetails>
    {
        private IDbConnection dbConnection = null;

        public ProductUnitsRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool AddUnitinLastOfList(ProductUnitsDetails produnit, int newqty)
        {
            var result = false;
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: Update parent qty and flag (parent means the old pcs unit)
                    string sql = string.Format("update productunits set qty = {2}, pcsflag = '{3}'  where itemid = {0} and seq = {1} ",
                                        produnit.id,
                                        produnit.seq - 1,
                                        newqty,
                                        "N");

                    var count = dbConnection.Execute(sql);
                    result = count > 0;

                    //Step 2: Adding new unit
                    string sql2 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                produnit.itemid,
                                                produnit.seq,
                                                produnit.unitcode,
                                                produnit.qty,
                                                produnit.pcsflag
                                                );
                    var count2 =  dbConnection.Execute(sql2, produnit);
                    result = count2 > 0;

                    tran.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    return result;
                }
            }
        }

        public bool AddUnitinfirstOfList(ProductUnitsDetails produnit)
        {
            var result = false;
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: update all sequence for this product
                    string sql = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                                produnit.itemid,
                                                produnit.seq);
                    var count = dbConnection.Execute(sql);
                    result = count > 0;

                    //step 2: adding new unit to database
                    string sql2 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                produnit.itemid,
                                                produnit.seq,
                                                produnit.unitcode,
                                                produnit.qty,
                                                produnit.pcsflag
                                                );
                    var count2 = dbConnection.Execute(sql2, produnit);
                    result = count2 > 0;

                    tran.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    return result;
                }
            }
        }

        public bool AddUnitinmiddletOfList(ProductUnitsDetails produnit, int newqty)
        {
            var result = false;
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: update parent qty
                    string sql = string.Format("update productunits set qty = {2}'  where itemid = {0} and seq = {1} ",
                                        produnit.id,
                                        produnit.seq - 1,
                                        newqty);

                    var count = dbConnection.Execute(sql);
                    result = count > 0;

                    //step 2: update all sequence in DB from current seq to last seq
                    string sql2 = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                                produnit.itemid,
                                                produnit.seq);
                    var count2 = dbConnection.Execute(sql);
                    result = count2 > 0;

                    //step 2: adding new unit to database
                    string sql3 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                produnit.itemid,
                                                produnit.seq,
                                                produnit.unitcode,
                                                produnit.qty,
                                                produnit.pcsflag
                                                );
                    var count3 = dbConnection.Execute(sql2, produnit);
                    result = count3 > 0;

                    tran.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    return result;
                }
            }
        }

        public bool Addtwounits(ProductUnitsDetails parent, ProductUnitsDetails child)
        {
            var result = false;
            using (var tran = dbConnection.BeginTransaction())
            {
                try
                {
                    // multiple operations involving here

                    //step 1: add parent unit
                    string sql = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                parent.itemid,
                                                parent.seq,
                                                parent.unitcode,
                                                parent.qty,
                                                parent.pcsflag
                                                );
                    var count = dbConnection.Execute(sql, parent);
                    result = count > 0;

                    //step 2: adding new unit to database
                    string sql2 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                child.itemid,
                                                child.seq,
                                                child.unitcode,
                                                child.qty,
                                                child.pcsflag
                                                );
                    var count2 = dbConnection.Execute(sql2, child);
                    result = count > 0;

                    tran.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    return result;
                }
            }
        }

        public bool Add(ProductUnitsDetails produnit)
        {
            var result = false;
            try
            {
                string sql = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                            produnit.itemid,
                                            produnit.seq,
                                            produnit.unitcode,
                                            produnit.qty,
                                            produnit.pcsflag
                                            );
                Console.WriteLine(sql);

                var count = dbConnection.Execute(sql, produnit);
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

        public List<ProductUnitsDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductUnitsDetails> GetAll(int itemid)
        {
            try
            {
                var queryResult = dbConnection.Query<ProductUnitsDetails>("select * from productunits where itemid = " + itemid);

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductUnitsDetails GetById(int itemid)
        {
            throw new NotImplementedException();
        }

        public List<ProductUnitsDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductUnitsDetails entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSeqbyincrease(int itemid, int currseq)
        {
            var result = false;
            try
            {
                string sql = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                            itemid, 
                                            currseq);

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

        public bool UpdateSeqbydecrease(int itemid, int currseq)
        {
            var result = false;
            try
            {
                string sql = string.Format("update productunits set seq = seq - 1 where itemid = {0} and seq >= {1} ",
                                            itemid,
                                            currseq);

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

        public bool Updateqtyandflag(int itemid, int currseq, int newqty, string pcsflag)
        {
            var result = false;
            try
            {
                string sql = string.Format("update productunits set qty = {2}, pcsflag = '{3}'  where itemid = {0} and seq = {1} ",
                                            itemid,
                                            currseq,
                                            newqty,
                                            pcsflag);

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
    }
}
