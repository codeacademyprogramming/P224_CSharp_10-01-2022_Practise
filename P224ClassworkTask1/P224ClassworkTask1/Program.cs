using P224ClassworkTask1.Models;
using System;

namespace P224ClassworkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product("corek",1, Enums.ProductType.Bakery);
            Product pr2 = new Product("beluqa", 70, Enums.ProductType.Fish);

            Console.WriteLine(pr1 );
            Console.WriteLine(pr2);
        }
    }
}
