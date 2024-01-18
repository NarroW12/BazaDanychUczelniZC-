using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uczelnia
{
    public class WykladowcyDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";
        
        public static List<Teachers> pobierzWykladowcow()
        {
            List<Teachers> listaNauczycieli = new List<Teachers>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzWykladowcow", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Teachers teachers = new Teachers
                            {
                                WykladowcaId = Convert.ToInt32(reader["WykladowcaID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                Stopien = reader["Stopien"].ToString(),
                                Specjalizacja =reader["Specjalizacja"].ToString()
                            };

                            listaNauczycieli.Add(teachers);
                        }
                    }
                }
            }

            return listaNauczycieli;
        }
    }
}
