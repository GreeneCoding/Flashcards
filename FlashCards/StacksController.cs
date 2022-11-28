using System.Configuration;
using System.Data.SqlClient;

namespace Flashcards;

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
                SqlDataReader reader = tableCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stacksData.Add(new Stacks
                        {
                            Id = reader.GetInt32(0),
                            StackName = reader.GetString(1)
                        }
                        );
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

            }
        }
    }
    public static List<Stacks> ViewStacksbyName(string stackName)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (var tableCmd = connection.CreateCommand())
            {
                connection.Open();
                tableCmd.CommandText = @"SELECT StackName FROM Stacks WHERE @StackName = stackName";
                tableCmd.Parameters.AddWithValue("@StackName",stackName);
                tableCmd.ExecuteNonQuery();

                List<Stacks> stacksData = new();
                SqlDataReader reader = tableCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stacksData.Add(new Stacks
                        {
                            StackName = reader.GetString(0)
                        }
                        );
                    }
                }
                return stacksData;

            }
        }
    }
    public static void CreateStacks(string stackName)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (var tableCmd = connection.CreateCommand())
            {
                connection.Open();
                tableCmd.CommandText = @"INSERT INTO Stacks (StackName) VALUES (@StackName)";
                tableCmd.Parameters.AddWithValue("@StackName", stackName);
                tableCmd.ExecuteNonQuery();
            }
        }

    }
}
