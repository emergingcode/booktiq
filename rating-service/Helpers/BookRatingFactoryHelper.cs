using System;
using System.Collections.Generic;

using RatingService.Models;

namespace RatingService.Helpers
{
    public static class BookRatingFactoryHelper
    {
        public static List<BookRating> GenerateBookRatings()
        {
            return new List<BookRating>
            {
                new BookRating
                {
                    Code = Guid.Parse("3872339b-5556-4c94-b7ca-2cc8abde32d8"),
                    Stars = 4.5m
                },
                new BookRating
                {
                    Code = Guid.Parse("6ef14d71-cd31-4c94-b88d-9d2dc26e3fb1"),
                    Stars = 3
                },
                new BookRating
                {
                    Code = Guid.Parse("24eca492-67f3-4dac-a66e-1643bc6766e8"),
                    Stars = 3.5m
                },
                new BookRating
                {
                    Code = Guid.Parse("2307feb3-d6e2-4758-968f-069833510018"),
                    Stars = 4
                },
                new BookRating
                {
                    Code = Guid.Parse("22d1e9b8-af4e-4859-a55b-5c6fd573736a"),
                    Stars = 4.5m
                }
            };
        }
    }
}