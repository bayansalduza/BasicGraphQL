using BasicGraphQL.Domain.Entities;
using BasicGraphQL.Infrastructure.Context;

namespace BasicGraphQL.Application.GraphQL
{
    public class Query
    {
        public List<Book> GetBooks()
        {
            return FakeDbContext.GetBooks();
        }

        public Book? GetBookById(int id)
        {
            return FakeDbContext.GetBooks().FirstOrDefault(b => b.Id == id);
        }
    }
}
