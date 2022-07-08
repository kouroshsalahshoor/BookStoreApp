using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace BookStoreApp.Api.Data
{
    [Index(nameof(Isbn), IsUnique = true)]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        [Precision(18, 2)]
        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author? Author { get; set; }
    }
}