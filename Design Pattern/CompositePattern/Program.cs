using CompositePattern.Transparent;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------CompositePattern--------------------");
            Console.WriteLine();

            //透明式
            Folder myWord = new Word();
            myWord.Open();
            myWord.Add(new SonFolder());
            myWord.Remove(new SonFolder());

            Folder myFolder = new SonFolder();
            myFolder.Open();
            myFolder.Add(new SonFolder());
            myFolder.Remove(new SonFolder());
            Console.WriteLine("--------------------------------------------------------");

            //安全式
            Safety.Folder excel = new Safety.Excel();
            excel.Open();

            Safety.Folder myFolder1 = new Safety.NextFolder();
            myFolder1.Open();
            ((Safety.SonFolder)myFolder1).Add(new Safety.NextFolder());
            ((Safety.SonFolder)myFolder1).Remove(new Safety.NextFolder());
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
