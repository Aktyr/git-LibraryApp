using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Библиотека
{
    public class Library
    {
        public List<Book> books;     

        public Library() 
        {
            books = new List<Book>();
        }

        public void ShowListBooks()
        {
            if (books.Count == null)
            {
                Console.WriteLine("В библиотеке нет книг\n");
                return;
            }

            Console.WriteLine("Книги в библиотеке:\n");
            foreach (var book in books)
            {
                Console.WriteLine($"{book}\n");
            }
        }

        public void AddBook(string bookName, string author, int year, int bookCount)
        {
            var book = new Book(bookName, author, year, bookCount);
            books.Add(book);
            Console.WriteLine($"Книга добавлена:\n{book}\n");
        }

        public void RemoveBook(string bookName)
        {
            var book = books.Find(b => b.bookName.Equals(bookName, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Книга удалена:\n{book}\n");
            }
            else
            {
                Console.WriteLine($"Книга не найдена:\n{bookName}\n");
            }
        }
    }

    public class Book
    {
        public string bookName;
        public string autor;
        public int year;
        public int bookCount;

        public Book(string BookName, string Autor, int Year, int BookCount)
        {
            bookName = BookName;
            autor = Autor;
            year = Year;
            bookCount = BookCount;
        }

        public override string ToString()
        {
            return $"Название: {bookName}\n" +
                $"Автор: {autor}\n" +
                $"Год: {year}\n" +
                $"Копий на складе: {bookCount}";
        }

    }

    public class IssuedBook //доделать
    {
        public int id;
        public Book book;
        public User user;
        public DateTime ussueDate;
        public DateTime returnDeadline;
    }
    public class Debtor //доделать
    {
        public int id;
        public User User;
        public Book book;
        public TimeSpan Overdue; // Разница между текущей датой и сроком возврата
    }
}
