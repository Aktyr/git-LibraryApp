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
        public List<Users> users;
        public List<IssuedBook> issuedBooks;
        public List<Debtor> debtors;

        public Library() 
        {
            books = new List<Book>();
            issuedBooks = new List<IssuedBook>();
            debtors = new List<Debtor>();
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
        public void GiveBook(User user, Book book)//доделать
        {
            user.issuedBook.Add(book);        
            //
            books.Remove(book);
        }
      
    }

}
