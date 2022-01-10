using P224Example.Models;
using P224Example.Services;
using System;

namespace P224Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book("nino","jony",400);
            //Book book2 = new Book("animal", "developer", 400);
            //Console.WriteLine(book1);
            //Console.WriteLine(book2);
            string str = ReturnStr();
            Console.WriteLine(ReturnStr());
            string[] arr = str.Split(" ");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Library library = new Library();
            foreach (var item in library.Booklist)
            {
                Console.WriteLine(item);
            }

        }

        static string ReturnStr()
        {
            return "Hello World";
        }
    }
}
