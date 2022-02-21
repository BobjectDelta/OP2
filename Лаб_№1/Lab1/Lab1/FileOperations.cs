using System;
using System.Collections.Generic;
using System.IO;

namespace FileOp
{
    class FileOperations
    {
        public static List<string> InputText()
        {
            bool flag = true;
            string ctrl_line = "\u0004";
            List<string> text = new List<string>();
            
            while (flag)
            {
                Console.WriteLine("Enter your string (press CTRL+D+ENTER to stop input): ");
                string str = Console.ReadLine();
                if (str.Equals(ctrl_line))
                {
                    flag = false;                  
                }
                else
                {
                    text.Add(str);
                }
            }
            return text;
        }     

        public static bool GetFillingMode()
        {
            Console.WriteLine("Enter A to append or R to rewrite");
            char mode = Convert.ToChar(Console.ReadLine());
            bool flag;

            flag = mode.Equals('A') ? true : false;
            return flag;
        }
        public static void FileFilling(List<string> text, StreamWriter sw)
        {                      
            for (int i = 0; i < text.Count; i++)
            {
                sw.WriteLine(text[i]);
            }                               
        }

        public static void DisplayFile(StreamReader sr)
        {
            Console.WriteLine(sr.ReadToEnd());
        }

        public static List<string> FileEdit(List<string> text)
        {
            string str;
            int wanted_length;
            bool flag;
            List<string> new_text = new List<string>();

            
            for (int i = 0; i<text.Count; i++)
            {
                str = text[i];
                flag = true;               
                Console.WriteLine("String length is: " + str.Length);
                Console.Write("Enter wanted length: ");
                wanted_length = Convert.ToInt32(Console.ReadLine());

                if (wanted_length > str.Length)
                {
                    for (int j = 0; wanted_length != str.Length && j<str.Length; j++)
                    {
                        for (int g = 0; g < str.Length && flag; g++)
                        {
                            if (str[g] == ' ')
                            {
                                str = str.Insert(g, " ");
                                while (str[g] == ' ')
                                    g++;
                            }                          
                            flag = wanted_length == str.Length ? false : true;
                            if (!str.Contains(' '))
                            {
                                flag = false;
                            }
                        }                                              
                    }                   
                }
                new_text.Add(str);
            }
            return new_text;
        }
    }
}
