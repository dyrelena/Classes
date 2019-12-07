using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookTitle, bookAuthor, bookContent;
            Console.WriteLine("Введите автора: ");
            bookAuthor = Console.ReadLine();

            Console.WriteLine("Введите название: ");
            bookTitle = Console.ReadLine();

            Console.WriteLine("Введите краткое описание: ");
            bookContent = Console.ReadLine();

            Book libraryBook = new Book(new Title {SetBookTitle = bookTitle}, new Author {SetBookAuthor=bookAuthor}, new Content { SetBookContent=bookContent});
            libraryBook.Show();
            Console.ReadLine();
        }
    }

    class Book
    {
        private Title bookTitle;
        private Author bookAuthor;
        private Content bookContent;  
        
        public Book(Title bookTitle, Author bookAuthor, Content bookContent)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.bookContent = bookContent;
        }

        public void Show()
        {
            bookTitle.Show();
            bookAuthor.Show();
            bookContent.Show();
        }
    }

    class Title
    {
        string title;

        public string SetBookTitle
        {
            set
            {
                title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название: " + title);
            Console.ResetColor();
        }
    }

    class Author
    {
        string author;

        public string SetBookAuthor
        {
            set
            {
                author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + author);
            Console.ResetColor();
        }
    }

    class Content
    {
        string content;

        public string SetBookContent
        {
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Содержание: " + content);
            Console.ResetColor();
        }
    }
}
