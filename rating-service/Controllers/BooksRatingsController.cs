using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using RatingService.Helpers;
using RatingService.Models;

namespace rating_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksRatingsController : ControllerBase
    {
        private readonly IEnumerable<BookRating> BookRatings;

        public BooksRatingsController()
        {
            BookRatings = BookRatingFactoryHelper.GenerateBookRatings();
        }

        [HttpGet]
        public IEnumerable<BookRating> Get()
        {
            return BookRatings;
        }

        [HttpGet("{code:guid}")]
        public BookRating Get(Guid code)
        {
            return BookRatings.Where(br => br.Code == code).SingleOrDefault();
        }
    }
}