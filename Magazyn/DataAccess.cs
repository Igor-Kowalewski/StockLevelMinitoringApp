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
        public void DodajOsobe(string imie, string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaMagDB")))
            {
                List<Klient> klienci = new List<Klient>();

                klienci.Add(new Klient {Imie = imie, Nazwisko = nazwisko });

                connection.Execute("dbo.Dodaj @Imie, @Nazwisko", klienci);
            }
        }

        public List<Klient> ZnajdzOsobe(string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaMagDB")))
            {
                var output = connection.Query<Klient>($"select * from Klienci where nazwisko = '{ nazwisko }'").ToList();
                return output;
            }
        }
    }
}
