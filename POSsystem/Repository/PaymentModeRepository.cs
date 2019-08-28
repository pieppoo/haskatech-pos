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
    public class PaymentModeRepository : IRepository<PaymentModeDetails>
    {
        private IDbConnection dbConnection = null;

        public PaymentModeRepository()
        {
            dbConnection = new MySqlConnection(Settings.Default.connection_string);
        }
        public bool Add(PaymentModeDetails entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentModeDetails> GetAll()
        {
            try
            {
                var queryResult = dbConnection.Query<PaymentModeDetails >("SELECT * FROM payment_mode;");

                return queryResult.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public PaymentModeDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentModeDetails> Search(params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaymentModeDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
