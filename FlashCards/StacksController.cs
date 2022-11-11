using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Flashcards
{
    internal class StacksController
    {
        //TALKS TO THE DATABASE - Stacks Table, in the middle of refactoring SQLite code to SQLclient code
        static string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        public static void ViewStacksTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var tableCmd = connection.CreateCommand())
                {
                    connection.Open();
                    tableCmd.CommandText = @"Select * from Stacks";
                    tableCmd.ExecuteNonQuery();

                    List<Stacks> stacksData = new();
                    SqliteDataReader reader = tableCmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            stacksData.Add(new Stacks
                            {
                                Id = 
                            }
                            );
                        }
                    }

                }
            }
        }
    }
}
