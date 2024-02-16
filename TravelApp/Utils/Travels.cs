using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TravelApp
{
    public class Travels
    {
        private List<object[]> itemList = new List<object[]>();

        private static readonly Travels instance = new Travels();

        public static Travels Instance => instance;

        private Travels() { }

        public IReadOnlyList<object[]> ItemList => itemList;

        public void AddItem(object[] item)
        {
            itemList.Add(item);
        }

        public void AddItems(List<object[]> items)
        {
            itemList.AddRange(items);
        }

        public void RemoveItem(object[] item)
        {
            itemList.Remove(item);
        }

        public void ClearItems()
        {
            itemList.Clear();
        }

        public int GetLastID()
        {
            if (itemList.Count > 0)
            {
                object[] lastItem = itemList[itemList.Count - 1];
                return (int)lastItem[0];
            }
            else
            {
                return 0;
            }
        }

        public IReadOnlyList<object[]> GetItemList()
        {
            return itemList.AsReadOnly();
        }
    }
}
