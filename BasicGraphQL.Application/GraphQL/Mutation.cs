using BasicGraphQL.Domain.Entities;
using BasicGraphQL.Infrastructure.Context;

namespace BasicGraphQL.Application.GraphQL
{
    public class Mutation
    {
        public Book AddBook(string title, string author)
        {
            var newBook = new Book
            {
                Title = title,
                Author = author
            };

            return FakeDbContext.AddBook(newBook);
        }
    }
}
