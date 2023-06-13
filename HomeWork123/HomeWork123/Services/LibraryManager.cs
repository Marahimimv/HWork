using HomeWork123.Interface;
using HomeWork123.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork123.Services
{
    public class LibraryManager : ILibraryManager
    {

        private Books[] _books;
        public Books[] Books { get => _books; }
        public void Add(string name, string author, string genre, int pageCount, Books book)
        {

            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;


        }


    }
}
