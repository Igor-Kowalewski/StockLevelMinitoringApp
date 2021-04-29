using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Magazyn
{
    class DataAccess
    {
        public void AddClient(string imie, string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaMagDB")))
            {
                List<Customer> klienci = new List<Customer>
                {
                    new Customer { Imie = imie, Nazwisko = nazwisko }
                };

                connection.Execute("dbo.Dodaj @Imie, @Nazwisko", klienci);
            }
        }

        public List<Customer> SearchClient(string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaMagDB")))
            {
                var output = connection.Query<Customer>($"select * from Klienci where nazwisko = '{ nazwisko }'").ToList();
                return output;
            }
        }
    }
}
