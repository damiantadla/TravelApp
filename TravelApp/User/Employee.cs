using System;
using System.Collections.Generic;

namespace TravelApp
{
    public class Employee : Person
    {
        private static readonly Employee instance = new Employee();

        public static Employee Instance => instance;

        private Employee() { }

        public string GetLogin()
        {
            return itemList.Count > 0 ? itemList[0][3].ToString() : null;
        }

        public string GetPassword()
        {
            return itemList.Count > 0 ? itemList[0][4].ToString() : null;
        }

        public string GetName()
        {
            return itemList.Count > 0 ? itemList[0][1].ToString() : null;
        }
    }
}
