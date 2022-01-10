using P224Example.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Services
{
    class Library
    {
        public List<Book> Booklist => _booklist;

        private List<Book> _booklist;
        public Library()
        {
            _booklist = new List<Book>();
        }
        public List<Book> FindAllBooksByName(string value)
        {
            return _booklist.FindAll(s => s.Name.ToUpper().Contains(value.ToUpper()));
        }

        public void RemoveAllBookByName(string str)
        {
            _booklist.RemoveAll(x => x.Name.ToUpper().Contains(str.ToUpper()));
                

        }
        public List<Book> SearchBooks(string str)
        {
            return _booklist.FindAll(a=>a.Name.ToUpper().Contains(str.ToUpper())|| a.AuthorName.ToUpper().Contains(str.ToUpper()) || a.PageCount.ToString().Contains(str));
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return _booklist.FindAll(q => q.PageCount > min && q.PageCount < max);
        }

        public void RemoveByNo(string value)
        {
            Book delBook = _booklist.Find(b => b.Code.Contains(value.ToUpper()));
            if (delBook != null)
            {
                _booklist.Remove(delBook);
            }
        }
    }
}
