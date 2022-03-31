using DELEGATE._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DELEGATE._2.Models
{
    internal class Book:IEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }
        public int _id;
        public int Id { get;  }

        public Book(string name, string authorname, int pagecount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public void Showinfo()
        {
            Console.WriteLine($"Id:{Id} - Name:{Name} - AuthorName:{AuthorName} - PageCount:{PageCount}");
        }
    }
}
