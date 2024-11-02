using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Библиотека
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Добавляем книги
            library.AddBook("1984", "George Orwell", 1949, 5);
            library.AddBook("Brave New World", "Aldous Huxley", 1932, 3);
            library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", 1925, 2);

            // Список книг
            library.ShowListBooks();

            // Удаляем книгу
            library.RemoveBook("1984");

            // Список книг после удаления
            library.ShowListBooks();
        }
    }
}
