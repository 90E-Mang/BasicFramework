using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    public class Book
    {
        string bookName;
        string author;
        string publisher;
        int pubYear;

        public Book(string BookName, string Author)
        {
            this.bookName = BookName;
            this.author = Author;
        }
        public Book(string BookName, string Author, string Publisher, int PubYear)
        {
            this.bookName = BookName;
            this.author = Author;
            this.publisher = Publisher;
            this.pubYear = PubYear;
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public int PubYear
        {
            get { return pubYear; }
            set { pubYear = value; }
        }

        public void chkBook()
        {
            Console.WriteLine($"책 제목 : {bookName}, 작가 : {author}, 출판사 : {publisher}, 출판연도 : {pubYear}");
        }
    }
}
