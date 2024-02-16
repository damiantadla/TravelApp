using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TravelApp
{
    internal class GetDataBase : BaseDataBase
    {
        public List<object[]> Connect(string query)
        {
            List<object[]> data = new List<object[]>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            reader.GetValues(row);
                            data.Add(row);
                        }
                    }
                }
            }

            return data;
        }
    }
}
