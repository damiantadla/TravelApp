using System;
using System.Collections.Generic;

namespace TravelApp
{
    public class Client : Person
    {
        private static readonly Client instance = new Client();

        public static Client Instance => instance;

        private Client() { }
    }
}