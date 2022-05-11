using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class FileIO
    {
        public static bool GetFileInputMode()
        {
            Console.WriteLine("Enter R to rewrite file or A to append it:");
            char mode = Convert.ToChar(Console.ReadLine());
            bool flag;

            flag = mode.Equals('A') ? true : false;
            return flag;
        }

        public static void FileInput(List<Item> items, string path, bool mode)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Append, FileAccess.Write));
            if (mode)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    bw.Write(items[i].GetAllAtributes() + "\n");
                }
            }
            else
            {
                bw.Close();
                bw = new BinaryWriter(File.Open(path, FileMode.Create, FileAccess.Write));
                for (int i = 0; i < items.Count; i++)
                {
                    bw.Write(items[i].GetName() + " " + items[i].GetValue() + " " + items[i].GetProdDate() + " " + items[i].GetExpireDate() + "\n");
                }
            }
            bw.Close();
        }
        public static List<Item> InputItemList()
        {
            bool flag = true;
            string ctrl_line = "\u0004";
            string productionDate = "";
            string expireDate = "";
            string name = "";
            string buffer;
            double value = 0;
            List<Item> items = new List<Item>();
            while (flag)
            {
                Console.WriteLine("Enter item attributes (name, value, production date, expire date)");
                Console.WriteLine("Press CTRL+D+ENTER to stop input");
                buffer = Console.ReadLine();
                if (!buffer.Equals(ctrl_line))
                {
                    name = buffer;
                    value = Convert.ToDouble(Console.ReadLine());
                    productionDate = Console.ReadLine();
                    expireDate = Console.ReadLine();                 
                    while (!(Convert.ToDateTime(productionDate) < Convert.ToDateTime(expireDate) && DateTime.Today >= Convert.ToDateTime(productionDate)))
                    {
                        Console.WriteLine("Date error. Enter production and expire dates again.");
                        productionDate = Console.ReadLine();
                        expireDate = Console.ReadLine();
                    }
                    Item item = new Item(name, productionDate, expireDate, value);
                    items.Add(item);
                }
                else              
                    flag = false;               
            }
            return items;
        }

        public static void FileOutput(string path)
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            while(br.PeekChar() > -1)
                Console.WriteLine(br.ReadString());
            br.Close();
        }

        public static List<Item> ReadFile(string path)
        {
            string info;          
            List<Item> items = new List<Item>();
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            while(br.PeekChar() > -1)
            {
                info = br.ReadString();
                string[] splittedInfo = info.Split(' ');
                Item item = new Item(splittedInfo[0],splittedInfo[2], splittedInfo[3], Convert.ToDouble(splittedInfo[1]));
                items.Add(item);
            }
            return items;
        }
    }
}