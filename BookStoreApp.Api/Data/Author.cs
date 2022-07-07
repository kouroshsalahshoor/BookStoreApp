using System.Text.Json.Serialization;

namespace BookStoreApp.Api.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        [JsonIgnore]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}