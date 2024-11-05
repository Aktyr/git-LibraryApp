using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
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

    public class IssuedBook //выданные книги, доделать
    {
        public Book book;
        public User user;
        public DateTime ussueDate;
        public DateTime returnDeadline;
    }
    public class Debtor //должники, доделать
    {
        public User User;
        public Book book;
        public TimeSpan Overdue; // Разница между текущей датой и сроком возврата        
    }
}
