using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;

namespace TravelApp
{
    internal class SetDataBase : BaseDataBase
    {
        public void AddClient(int IDClient, string Name, string Surname, string PhoneNumber, int IDTravel)
        {
            string query = "INSERT INTO Clients (IDClient, Name, Surname, PhoneNumber, IDTravel) VALUES (@IDClient, @Name, @Surname, @PhoneNumber, @IDTravel)";
            var parameters = new Dictionary<string, object>
            {
                { "@IDClient", IDClient },
                { "@Name", Name },
                { "@Surname", Surname },
                { "@PhoneNumber", PhoneNumber },
                { "@IDTravel", IDTravel }
            };
            ExecuteNonQuery(query, parameters);
        }

        public void AddTravel(int IDTravel, string TravelsName, string Address, DateTime Date, int IDEmployees, int Price)
        {
            string query = "INSERT INTO Travels (IDTravel, TravelsName, Address, Date, IDEmployees, Price) VALUES (@IDTravel, @TravelsName, @Address, @Date, @IDEmployees, @Price)";
            var parameters = new Dictionary<string, object>
            {
                { "@IDTravel", IDTravel },
                { "@TravelsName", TravelsName },
                { "@Address", Address },
                { "@Date", Date },
                { "@IDEmployees", IDEmployees },
                { "@Price", Price }
            };
            ExecuteNonQuery(query, parameters);
        }
    }
}
