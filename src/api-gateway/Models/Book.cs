using System;

namespace api_gateway.Models
{
    public class BookRating
    {
        public Guid Code { get; set; }
        public decimal Stars { get; set; }
    }

    public class BookPrice
    {
        public Guid Code { get; set; }
        public decimal Price { get; set; }
    }

    public class Book
    {
        public Guid Code { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }

        public decimal Price { get; set; }

        public decimal Stars { get; set; }
    }
}