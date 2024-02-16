using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class Person
    {
        protected List<object[]> itemList = new List<object[]>();

        public void AddUser(List<object[]> items)
        {
            itemList.AddRange(items);
        }

        public void RemoveUser(object[] item)
        {
            itemList.Remove(item);
        }

        public void ClearUser()
        {
            itemList.Clear();
        }

        public int GetLastUserID()
        {
            return itemList.Count;
        }

        public IReadOnlyList<object[]> GetItemList()
        {
            return itemList.AsReadOnly();
        }
    }

    public class Class1
    {
    }
}