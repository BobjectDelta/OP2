using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab2
{
    internal class FileEditing
    {
        public static List<Item> EditItemList(List<Item> items)
        {
            double prodExpireInterval = 0;
            double todayExpireInterval = 0;
            DateTime prodDate = new DateTime();
            DateTime expireDate = new DateTime();
            List<Item> editedItems = new List<Item>();
            Item currentItem = new Item("", "", "", 0);

            for (int i = 0; i < items.Count; i++)
            {
                currentItem = items[i];               
                prodDate = Convert.ToDateTime(currentItem.GetProdDate());
                expireDate = Convert.ToDateTime(currentItem.GetExpireDate());
                prodExpireInterval = (expireDate.Subtract(prodDate).TotalDays);
                todayExpireInterval = (expireDate.Subtract(DateTime.Today).TotalDays);

                if(todayExpireInterval < prodExpireInterval/10)
                {
                    editedItems.Add(currentItem);
                }
            }

            return editedItems;
        }

        public static List<Item> GetLastDaysItems(List<Item> items)
        {
            List<Item> lastDaysItems = new List<Item>();
            Item currentItem = new Item("", "", "", 0);
            DateTime prodDate = new DateTime();

            for (int i = 0; i < items.Count; i++)
            {
                currentItem = items[i];
                prodDate = Convert.ToDateTime(currentItem.GetProdDate());
                if(((DateTime.Today).Subtract(prodDate)).TotalDays <= 10)
                {
                    lastDaysItems.Add(currentItem);
                }
            }

            return lastDaysItems;
        }

        public static void PrintList(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].GetAllAtributes());
            }
        }
    }
}
