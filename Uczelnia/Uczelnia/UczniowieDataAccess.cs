using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Uczelnia
{
    public class UczniowieDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public List<Uczniowie> PobierzUczniow()
        {
            List<Uczniowie> listaUczniow = new List<Uczniowie>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzUczniow", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Uczniowie uczniowie = new Uczniowie
                            {
                                IdUczniowie = Convert.ToInt32(reader["UczenID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                IndexNumber = reader["NrIndeksu"].ToString(),
                                Semester = Convert.ToInt32(reader["Semestr"])
                            };

                            listaUczniow.Add(uczniowie);
                        }
                    }
                }
            }

            return listaUczniow;
        }
    }
}
