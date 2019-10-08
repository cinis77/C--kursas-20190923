using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace KCSDuombazes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\KCSDuombazes\KCSDuombazes\KCS.mdf;Integrated Security=True";
            string querry = "Insert into students(Vardas, Pavarde) values(@Vardas, @Pavarde)";
            string querry1 = "Insert into students(Vardas, Pavarde, Telefonas) values(@Vardas, @Pavarde, @Telefonas)";
            string querry2 = "Insert into students(Vardas, Pavarde, Telefonas, email) values(@Vardas, @Pavarde, @Telefonas, @email)";
            string querry3 = "Select * from students where Vardas like '%as' order by Vardas";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                #region Insert

                /*
                using (SqlCommand com = new SqlCommand(querry, connection))
                {
                    com.Parameters.AddWithValue("@Vardas", "Rokas");
                    com.Parameters.AddWithValue("@Pavarde", "Rokaitis");
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();
                }

                using (SqlCommand com = new SqlCommand(querry1, connection))
                {
                    com.Parameters.AddWithValue("@Vardas", "Petras");
                    com.Parameters.AddWithValue("@Pavarde", "Petraitis");
                    com.Parameters.AddWithValue("@Telefonas", "458792");
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand com = new SqlCommand(querry2, connection))
                {
                    com.Parameters.AddWithValue("@Vardas", "Povilas");
                    com.Parameters.AddWithValue("@Pavarde", "Karas");
                    com.Parameters.AddWithValue("@Telefonas", "47952");
                    com.Parameters.AddWithValue("@email", "pkar@gmail.com");
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();
                }*/

                #endregion Insert

                using (SqlCommand comm = new SqlCommand(querry3, connection))
                {
                    connection.Open();
                    var reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Id"] + " " + reader["Vardas"] + " " + reader["Pavarde"]);
                    }
                    connection.Close();
                }
            }
        }
    }
}