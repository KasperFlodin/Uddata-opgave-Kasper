using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata_opgave.Controllers
{
    class ElevCRUD
    {

        const string connectionString = "Data Source=.;Initial Catalog=BuhuZooDB;Integrated Security=True";

        public List<LærerClass> Select()
        {
            List<ElevClass> Elevlist = new List<ElevClass>();
            string sqllærer = $"SELECT id,[name], fag FROM Lærer";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqllærer, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Public int Id { Get; set; }
                        //Public string name { Get; set; }
                        //Public Gender Gender { Get; set; }
                        //Public DateTime DateOfBirth { Get; set; }
                        //Public Color Color { Get; set; }
                        //Public String Race { Get; set; }
                        //Console.WriteLine($"{reader[0]}, {reader[1]}, {reader[2]}");
                        Elevlist.Add(new ElevClass()
                        {
                            Id = (int)reader[0],
                            Name = (string)reader[1],
                            advarsler = (int)reader[2],
                            //DateOfBirth = (DateTime)reader[3],
                            //Gender = (Gender)Enum.Parse(typeof(Gender), reader[4].ToString()),
                        });

                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    Console.WriteLine("ERROR:" + ex.GetType() + ex.Message);
                    return null;
                }
            }
            return Elevlist;
        }

        public static int? Insert(LærerClass elev)
        {
            // Prepare a proper parameterized query 
            string sql = "INSERT INTO Lærer ([name], fag) " +
               "OUTPUT INSERTED.id " +
               "VALUES(@name, @fag)";

            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = elev.Name;
                        cmd.Parameters.Add("@advarsler", SqlDbType.NVarChar).Value = elev.lærerfag;
                        //cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = lærer.DateOfBirth;
                        //cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = lærer.Gender;

                        var id = cmd.ExecuteScalar();
                        return (int?)id;
                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    Console.WriteLine("ERROR:" + ex.GetType() + " " + ex.Message);
                    return null;
                }
            }

        }

    }
}
