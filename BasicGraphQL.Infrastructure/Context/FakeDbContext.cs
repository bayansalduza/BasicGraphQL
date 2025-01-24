using BasicGraphQL.Domain.Entities;

namespace BasicGraphQL.Infrastructure.Context
{
    public static class FakeDbContext
    {
        private static List<Book> _books = new List<Book>()
        {
            new Book { Id = 1, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy", Year = 1997, IsTurkish = false },
            new Book { Id = 2, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", Year = 1937, IsTurkish = false },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949, IsTurkish = false },
            new Book { Id = 4, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Year = 1960, IsTurkish = false },
            new Book { Id = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Year = 1925, IsTurkish = false },

            new Book { Id = 6, Title = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", Genre = "Fiction", Year = 1943, IsTurkish = true },
            new Book { Id = 7, Title = "Tutunamayanlar", Author = "Oğuz Atay", Genre = "Modern", Year = 1971, IsTurkish = true },
            new Book { Id = 8, Title = "İnce Memed", Author = "Yaşar Kemal", Genre = "Epic", Year = 1955, IsTurkish = true },
            new Book { Id = 9, Title = "Aşk", Author = "Elif Şafak", Genre = "Romance", Year = 2009, IsTurkish = true },
            new Book { Id = 10, Title = "Beyaz Zambaklar Ülkesi", Author = "Grigory Petrov", Genre = "Non-fiction", Year = 1923, IsTurkish = false },

            new Book { Id = 11, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Year = 1951, IsTurkish = false },
            new Book { Id = 12, Title = "The Da Vinci Code", Author = "Dan Brown", Genre = "Thriller", Year = 2003, IsTurkish = false },
            new Book { Id = 13, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Year = 1813, IsTurkish = false },
            new Book { Id = 14, Title = "Moby-Dick", Author = "Herman Melville", Genre = "Adventure", Year = 1851, IsTurkish = false },
            new Book { Id = 15, Title = "Sefiller (Les Misérables)", Author = "Victor Hugo", Genre = "Fiction", Year = 1862, IsTurkish = true }
        };

        public static List<Book> GetBooks()
        {
            return _books;
        }

        public static Book AddBook(Book book)
        {
            book.Id = _books.Max(b => b.Id) + 1;
            _books.Add(book);
            return book;
        }
    }
}
