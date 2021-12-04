using System;

namespace StructureAndEnumDemo
{
    struct Book
    {
        int isbn;
        string bookName;
        string bookAuthor;

        //  Error can not define empty constructor
        //public Book()
        //{

        //}
        public Book(int isbn, string bookName, string bookAuthor)
        {
            this.isbn = isbn;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
        }

        public string Display()
        {
            return $"ISBN={this.isbn}\nName={this.bookName}\nAuthor={this.bookAuthor}";
        }

    }
}
