using System;
using System.IO;
namespace existence._1
{
    class FileRead
    {
        public static void Main(string[] args)
        {
            string filename;
            while(true)
            {
                Console.WriteLine("\n----------MENU----------\n");
                Console.WriteLine("\n 1.Create a File");
                Console.WriteLine("\n 2.Existence of the File");
                Console.WriteLine("\n 3.Read the contents of the File");
                Console.WriteLine("\n 4.Exit");
                Console.WriteLine("\n Enter your choice: ");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.Write("\n Enter the file name to create: ");
                        filename = Console.ReadLine();
                        Console.WriteLine("\n Write the contents to the File: \n");
                        string r = Console.ReadLine();
                         using (StreamWriter fileStr = File.CreateText(filename))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("File is Created…");
                        break;
                    case 2:
                        Console.Write("\n Enter the file name:");
                        filename = Console.ReadLine();
                        if (File.Exists(filename))
                        {
                            Console.WriteLine("File exists...");
                        }
                        else
                        {
                            Console.WriteLine("File does not exist in the current directory!");

                        }
                        break;
                    case 3:
                        Console.Write("Enter the file name to read the contents:\n");
                        filename = Console.ReadLine();
                        if (File.Exists(filename))
                        {
                            using (StreamReader sr = File.OpenText(filename))
                            {
                                string s = "";
                                Console.WriteLine(" Here is the content of the file : ");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n Exiting...");
                        return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;
                }
            }
        }
    }
}
