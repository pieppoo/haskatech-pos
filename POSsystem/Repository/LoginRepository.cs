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
using POSsystem.Properties;

namespace POSsystem.Repository
{
    public class LoginRepository : IRepository<LoginDetails>
    {
        private IDbConnection dbConnection = null;

        public LoginRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }
        public bool Add(LoginDetails entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoginDetails> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<LoginDetails>("SELECT * FROM user");
                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
                return null;
            }
        }

        public List<LoginDetails> GetAll(string username)
        {
            try
            {
                var sql = "select * from user where username = '" + username + "'";
                var queryResult = dbConnection.Query<LoginDetails>(sql);
                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }
            return null;
        }

        public LoginDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoginDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(LoginDetails userdetail)
        {
            throw new NotImplementedException();
        }

        public bool Updatelastlogin(LoginDetails userdetail)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE user SET lastlogin = '{1}' WHERE ID = {0}",
                                            userdetail.id,
                                            userdetail.lastlogin);

                var count = dbConnection.Execute(sql, userdetail);
                result = count > 0;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, true);
            }

            return result;
        }

        public bool updatepswd(LoginDetails userdetail)
        {
            var result = false;
            try
            {
                string sql = string.Format("UPDATE user SET password = '{1}' WHERE ID = {0}",
                                            userdetail.id,
                                            userdetail.password);

                var count = dbConnection.Execute(sql, userdetail);
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
