using System.Configuration;
using System.Data.SqlClient;



namespace Flashcards
{
    internal class FlashcardsController
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        public static void CreateFlashcards(int stackId,string flashcardFront,string flashcardBack)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (var tableCmd = connection.CreateCommand())
                    {
                        connection.Open();
                        tableCmd.CommandText = @"INSERT INTO Flashcards (StackId, FlashcardFront, Flashcardback) VALUES (@StackId,@FlashcardFront,@FlashcardBack)";
                        tableCmd.Parameters.AddWithValue("@StackId", stackId);
                        tableCmd.Parameters.AddWithValue("@FlashcardFront", flashcardFront);
                        tableCmd.Parameters.AddWithValue("@FlashcardBack", flashcardBack);
                        tableCmd.ExecuteNonQuery();
                    }
                }

            
        }
    }
}
