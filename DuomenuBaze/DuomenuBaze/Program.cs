using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DuomenuBaze
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\DuomenuBaze\DuomenuBaze\Pavyzdine.mdf;Integrated Security=True";
            string query = "Insert into Lentele1(Vardas, Pavarde) Values(@Vardas, @Pavarde)";
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Vardas", "Pertas");
                command.Parameters.AddWithValue("@Pavarde", "Petraitis");
                connection.Open();
                var result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    Console.WriteLine("Nepavyko ikelti duomenu");
                }
            }
        }
    }
}