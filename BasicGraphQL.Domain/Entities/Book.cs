namespace BasicGraphQL.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Author { get; set; } 
        public string Genre { get; set; } 
        public int Year { get; set; } 
        public bool IsTurkish { get; set; }
    }
}
