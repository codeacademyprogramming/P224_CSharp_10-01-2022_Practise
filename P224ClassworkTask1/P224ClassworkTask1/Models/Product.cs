using P224ClassworkTask1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224ClassworkTask1.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        static int TotalCount;
        static int Count=1000;

        private string Code;
        public ProductType ProductType;
        public Product(string name,double price, ProductType productType)
        {
            Count++;
            TotalCount++;
            Name = name;
            Price = price;
            ProductType = productType;

            switch ((int)ProductType)
            {
                case (int)ProductType.Bakery:
                    Code = "BA" + Count;
                    DiscountedPrice = price - (price * 0.1);
                    break;
                case (int)ProductType.Drink:
                    Code = "Dr" + Count;
                    break;
                case (int)ProductType.Meat:
                    Code = "ME" + Count;
                    break;
                case (int)ProductType.Fish:
                    Code = "FI" + Count;
                    break;
                default:
                    Console.WriteLine("duzgun deyer daxil edin");
                    break;
            }
            
        }
        public override string ToString()
        {
            return $"{Name} {Price} {ProductType} {TotalCount} {DiscountedPrice} {Code}";
        }
    }
}
