using DELEGATE._2.Exceptions;
using DELEGATE._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DELEGATE._2.Models
{
    internal class Library:IEntity
    {
        public int BookLimit { get; set; }
        private static int _id;
        public int Id { get;  }

        private List<Book> _books;
        public Library(int bookLimit)
        {
            _id++;
           Id = _id;
            BookLimit = bookLimit;
          
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new NullReferenceException("book null ola bilmez!");

            if (_books.Exists(m => m.Name == book.Name && !m.IsDeleted))
                throw new AlreadyExistsException("bu adda kitab var!");

            if (_books.Count < BookLimit)
            {
                _books.Add(book);
                return;
            }

            throw new CapacityLimitException("limit doldu");
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez!");

            return _books.Find(m => !m.IsDeleted && m.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
          
            books.AddRange(_books.FindAll(m => !m.IsDeleted));

            return books;
        }

        public void DeleteBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez!");

            Book book = _books.Find(m => !m.IsDeleted && m.Id == id);
            if (book == null)
                throw new NotFoundException("bele  kitab yoxdur!");

            book.IsDeleted = true;
        }

        public void EditBookName(int? id, string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException("id ve name null ola bilmez!");

            Book book = _books.Find(m => !m.IsDeleted && m.Id == id);
            if (book == null)
                throw new NotFoundException("bele bir kitab yoxdur");

            book.Name = name;
        }

        public List<Book> FilterByPageCount(double minPrice, double maxPrice)
        {
            return _books.FindAll(m => m.IsDeleted && m.PageCount >= minPrice && m.PageCount <= maxPrice);
        }
    }
}
