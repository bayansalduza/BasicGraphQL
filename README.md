# BasicGraphQL

An ASP.NET Core 8 Web API project demonstrating how to use **GraphQL** with the Hot Chocolate library. This project includes examples for testing GraphQL endpoints using **Voyager** and **Postman**.

This project follows a layered architecture, including:

- **BasicGraphQL.Domain**: Contains the `Book` model.
- **BasicGraphQL.Infrastructure**: Provides in-memory fake data for demonstration purposes.
- **BasicGraphQL.Application**: Implements GraphQL queries and mutations.
- **BasicGraphQL.Api**: Exposes the GraphQL endpoint to handle client requests.

The project allows:

- Fetching all books (`getBooks`).
- Fetching a book by ID (`getBookById`).
- Adding a new book (`addBook`).
- Visualizing the GraphQL schema using Voyager.

---

## Technologies Used

This project is built using:

- **ASP.NET Core 8**
- **Hot Chocolate** for GraphQL server implementation.
- **GraphQL Voyager** for schema visualization.

---

## Running the Application

To run this project, ensure you have [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed. Then, follow these steps:

2. Access the endpoints:

   - **GraphQL Playground:** `http://localhost:5042/graphql`
   - **Voyager UI:** `http://localhost:5042/graphql-voyager`

---

## Testing the Application

### Testing with Voyager

1. Start the application.
2. Open your browser and navigate to `http://localhost:5042/graphql-voyager`.
3. Explore the schema and execute queries directly using the Voyager interface.

(*Insert your Voyager UI screenshot here*)

---

### Testing with Postman or curl

You can also test the GraphQL endpoint using Postman or curl. Below are some examples.

#### Fetch All Books

```bash
curl -X POST http://localhost:5042/graphql \
-H "Content-Type: application/json" \
-d '{"query": "query { getBooks { id title author genre year isTurkish } }"}'
```

#### Fetch Book by ID

```bash
curl -X POST http://localhost:5042/graphql \
-H "Content-Type: application/json" \
-d '{"query": "query { getBookById(id: 1) { id title author genre year isTurkish } }"}'
```

#### Add a New Book

```bash
curl -X POST http://localhost:5042/graphql \
-H "Content-Type: application/json" \
-d '{"query": "mutation { addBook(title: \"Clean Code\", author: \"Robert C. Martin\", genre: \"Non-fiction\", year: 2008, isTurkish: false) { id title author } }"}'
```

---

## Example Data

The application uses the following example books in the in-memory fake database:

| ID | Title                                    | Author         | Genre   | Year | Is Turkish |
| -- | ---------------------------------------- | -------------- | ------- | ---- | ---------- |
| 1  | Harry Potter and the Philosopher's Stone | J.K. Rowling   | Fantasy | 1997 | No         |
| 2  | Kürk Mantolu Madonna                     | Sabahattin Ali | Fiction | 1943 | Yes        |
| 3  | The Hobbit                               | J.R.R. Tolkien | Fantasy | 1937 | No         |
| 4  | İnce Memed                               | Yaşar Kemal    | Epic    | 1955 | Yes        |
..
