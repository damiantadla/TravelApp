using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    internal class BaseDataBase
    {
        protected string connectionString = "Server=DAMIAN;Database=TravelBase;Integrated Security=True;";

        protected void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
