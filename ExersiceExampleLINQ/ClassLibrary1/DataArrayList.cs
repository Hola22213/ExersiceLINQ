using System;
using System.Collections;

namespace DemoArraysLinq.Models
{
    public class DataArrayList
    {
        private ArrayList dataList;

        public DataArrayList()
        {
            dataList = new ArrayList();
        }

        public void AddItem(object item)
        {
            dataList.Add(item);
        }

        public void RemoveItem(object item)
        {
            dataList.Remove(item);
        }

        public void PrintItems()
        {
            foreach (var item in dataList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
