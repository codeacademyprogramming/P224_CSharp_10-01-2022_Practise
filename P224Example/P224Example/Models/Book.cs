using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Models
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        static int Count;

        public Book(string name,string authorname,int pagecount)
        {
            Count++;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = Name.ToUpper().Substring(0, 2) + Count;
        }
        public override string ToString()
        {
            return Code;
        }

    }
}
