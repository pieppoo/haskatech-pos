﻿using MySql.Data.MySqlClient;
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
using POSsystem.Common;

namespace POSsystem.Repository
{
    public class ProductUnitsRepository : IRepository<ProductUnitsDetails>
    {
        private IDbConnection dbConnection = null;

        public ProductUnitsRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }

        public bool AddUnitinLastOfList(ProductUnitsDetails produnit, int newqty, int newstock)
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

                    //step 1: Update parent qty and flag (parent means the old pcs unit)
                    string sql = string.Format("update productunits set qty = {2}, pcsflag = '{3}'  where itemid = {0} and seq = {1} ",
                                        produnit.itemid,
                                        produnit.seq - 1,
                                        newqty,
                                        "N");

                    var count = dbConnection.Execute(sql);
                    var firstresult = count > 0;

                    if(firstresult)
                    {
                        //Step 2: Adding new unit
                        string sql2 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                    produnit.itemid,
                                                    produnit.seq,
                                                    produnit.unitcode,
                                                    produnit.qty,
                                                    produnit.pcsflag
                                                    );
                        var count2 = dbConnection.Execute(sql2, produnit);
                        var result2 = count2 > 0;

                        if(result2)
                        {
                            //Step 3: Adding new unit
                            string sql3 = string.Format("update item set Stock = {0} where id = {1} ", 
                                                    newstock,
                                                    produnit.itemid
                                                    );
                            var count3 = dbConnection.Execute(sql3);
                            result = count3 > 0;
                        }

                        tran.Commit();
                        return result;
                    }
                    else
                    {
                        return firstresult;
                    }

                }
                catch (Exception ex)
                {
                    tran.Rollback(); // I tried commented it but it still rollback, meaning this line is not needed?
                    Logger.Log(ex, true);
                    return result;
                }
            }
        }

        public bool AddUnitinfirstOfList(ProductUnitsDetails produnit)
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

                    //step 1: update all sequence for this product
                    string sql = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                                produnit.itemid,
                                                produnit.seq);
                    var count = dbConnection.Execute(sql);
                    var firstresult = count > 0;

                    if (firstresult)
                    {
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
                    else
                    {
                        return firstresult;
                    }

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Logger.Log(ex, true);
                    return result;
                }
            }
        }

        public bool AddUnitinmiddletOfList(ProductUnitsDetails produnit, int newqty)
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

                    //step 1: update parent qty
                    string sql = string.Format("update productunits set qty = {2}  where itemid = {0} and seq = {1} ",
                                        produnit.itemid,
                                        produnit.seq - 1,
                                        newqty);

                    var count = dbConnection.Execute(sql);
                    var firsResult = count > 0;

                    if (firsResult)
                    {
                        //step 2: update all sequence in DB from current seq to last seq
                        string sql2 = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                                    produnit.itemid,
                                                    produnit.seq);
                        var count2 = dbConnection.Execute(sql2);
                        var SecondResult = count2 > 0;

                        if (SecondResult)
                        {
                            //step 3: adding new unit to database
                            string sql3 = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                        produnit.itemid,
                                                        produnit.seq,
                                                        produnit.unitcode,
                                                        produnit.qty,
                                                        produnit.pcsflag
                                                        );
                            var count3 = dbConnection.Execute(sql3, produnit);
                            result = count3 > 0;

                            tran.Commit();
                            return result;
                        }
                        else
                        {
                            tran.Rollback();
                            return SecondResult;
                        }
                    }
                    else
                        return firsResult;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Logger.Log(ex, true);
                    return result;
                }
            }
        }

        public bool Addtwounits(ProductUnitsDetails parent, ProductUnitsDetails child)
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

                    //step 1: add parent unit
                    string sql = string.Format("insert into productunits (itemid, seq, unitcode, qty, pcsflag ) values ({0}, {1}, '{2}', {3}, '{4}')",
                                                parent.itemid,
                                                parent.seq,
                                                parent.unitcode,
                                                parent.qty,
                                                parent.pcsflag
                                                );
                    var count = dbConnection.Execute(sql, parent);
                    var firstResult = count > 0;

                    if (firstResult)
                    {
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
                var count = dbConnection.Execute(sql, produnit);
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
                string sql = string.Format("delete from productunits where id = {0} ",
                                             id);

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool DeleteNOTRelated(int itemid, int seqno)
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

                    //step 1: remove selected unit
                    string sql = string.Format("delete from productunits where itemid = {0} and seq = {1} ",
                                                 itemid,
                                                 seqno);

                    var count = dbConnection.Execute(sql);
                     var firstResult = count > 0;

                    if (firstResult)
                    {
                        //step 2: update seq for all unit after the selected unit 
                        string sql2 = string.Format("update productunits set seq = seq - 1 where itemid = {0} and seq > {1} ",
                                                    itemid,
                                                    seqno);
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

        public bool DeleteRelatedmiddle(int itemid, int seqno)
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

                    //step 1: remove selected unit
                    string sql = string.Format("delete from productunits where itemid = {0} and seq = {1} ",
                                                 itemid,
                                                 seqno);

                    var count = dbConnection.Execute(sql);
                    var firstResult = count > 0;

                    if (firstResult)
                    {
                        //step 2: update seq for all unit after the selected unit 
                        string sql2 = string.Format("update productunits set seq = seq - 1 where itemid = {0} and seq > {1} ",
                                                    itemid,
                                                    seqno);
                        var count2 = dbConnection.Execute(sql2);
                        var secondresult = count2 > 0;

                        if (secondresult)
                        {
                            // step 3: update qty parent
                            string sql3 = string.Format("update productunits set qty = 0 where itemid = {0} and seq = {1} ",
                                                    itemid,
                                                    seqno-1);
                            var count3 = dbConnection.Execute(sql3);
                            result = count3 > 0;

                            tran.Commit();
                            return result;
                        }
                        else
                            return secondresult;


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

        public bool DeleteRelatedfirst(int itemid, int seqno)
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

                    //step 1: remove selected unit
                    string sql = string.Format("delete from productunits where itemid = {0} and seq = {1} ",
                                                 itemid,
                                                 seqno);

                    var count = dbConnection.Execute(sql);
                    var firstResult = count > 0;

                    if (firstResult)
                    {
                        //step 2: update seq for all unit after the selected unit 
                        string sql2 = string.Format("update productunits set seq = seq - 1 where itemid = {0} and seq > {1} ",
                                                    itemid,
                                                    seqno);
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

        public bool DeleteAll(int itemid)
        {
            var result = false;
            try
            {
                string sql = string.Format("delete from productunits where itemid = {0}",
                                             itemid);

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
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
                Logger.Log(ex, true);
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

        public bool Update(ProductUnitsDetails produnit)
        {
            var result = false;
            try
            {
                string sql = string.Format("update productunits set unitcode = '{2}' , qty = {3} where itemid = {0} and seq = {1} ",
                                            produnit.itemid,
                                            produnit.seq,
                                            produnit.unitcode,
                                            produnit.qty);

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool UpdateSeqbyincrease(int itemid, int currseq)
        {
            var result = false;
            try
            {
                string sql = string.Format("update productunits set seq = seq + 1 where itemid = {0} and seq >= {1} ",
                                            itemid, 
                                            currseq);

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
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

                var count = dbConnection.Execute(sql);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
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


                var count = dbConnection.Execute(sql);
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
