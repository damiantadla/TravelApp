using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    internal class RemoveDataBase : BaseDataBase
    {
        public void RemoveTravel(int IDTravel)
        {
            string query = "DELETE FROM Travels WHERE IDTravel = @IDTravel";
            var parameters = new Dictionary<string, object> { { "@IDTravel", IDTravel } };
            ExecuteNonQuery(query, parameters);
        }

        public void RemoveClient(int IDClient)
        {
            string query = "DELETE FROM Clients WHERE IDClient = @IDClient";
            var parameters = new Dictionary<string, object> { { "@IDClient", IDClient } };
            ExecuteNonQuery(query, parameters);
        }
    }
}
