using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TravelApp
{
    public class Cart
    {
        private List<object[]> itemList = new List<object[]>();

        private int sumCart; 
 
        private static readonly Cart instance = new Cart();

        public static Cart Instance => instance;

        private Cart() { }

        public IReadOnlyList<object[]> ItemList => itemList;

        public void AddItem(object[] item)
        {
            itemList.Add(item);
            sumCart += int.Parse(item[4].ToString()); 
        }

        public void RemoveItem(object[] item)
        {
            itemList.Remove(item);
            sumCart -= int.Parse(item[4].ToString());
        }

        public void ClearItems()
        {
            itemList.Clear();
            sumCart = 0;
        }

        public int getSumCart()
        {
            return sumCart;
        }

        public int getLastID()
        {
            return itemList.Count;
        }
    

        public IReadOnlyList<object[]> GetItemList()
        {
            return itemList.AsReadOnly();
        }
    }
}