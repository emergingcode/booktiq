using System;

namespace RatingService.Models
{
    public class BookRating
    {
        public Guid Code { get; set; }
        public decimal Stars { get; set; }
    }
}