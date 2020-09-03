using System;

namespace BookService.Models
{
    public class Book
    {
        public Guid Code { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}