using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\...\...\samples\wishList";
            Console.WriteLine("Enter directory name: 'shopping list'");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name: 'myshoppinglist.txt'");
            string fileName = "myshoppinglist.txt";

            

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
               Console.WriteLine("Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
