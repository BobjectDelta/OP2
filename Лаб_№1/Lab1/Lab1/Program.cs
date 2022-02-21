using System;
using System.Collections.Generic;
using System.IO;
using FileOp;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/nickp/Desktop/Лаби ОП/2 семестр/Лаб_№1/file.txt";
            string edited_path = "C:/Users/nickp/Desktop/Лаби ОП/2 семестр/Лаб_№1/edited_file.txt";

            StreamWriter sw;
            if (FileOperations.GetFillingMode())            
                sw = new StreamWriter(path, true);            
            else           
                sw = new StreamWriter(path, false);
            
            List<string> text = FileOperations.InputText();
            FileOperations.FileFilling(text, sw);
            sw.Close();
                      
            if (FileOperations.GetFillingMode())
                sw = new StreamWriter(edited_path, true);
            else
                sw = new StreamWriter(edited_path, false);

            List<string> new_text = FileOperations.FileEdit(text);
            FileOperations.FileFilling(new_text, sw);
            sw.Close();

            Console.WriteLine("Initial file:");
            StreamReader sr = new StreamReader(path);
            FileOperations.DisplayFile(sr);

            Console.WriteLine("Edited file:");
            sr = new StreamReader(edited_path);
            FileOperations.DisplayFile(sr);
        }
    }
}
