using System;
using System.Collections.Generic;
using System.Linq;

using BookService.Helpers;
using BookService.Models;

using Microsoft.AspNetCore.Mvc;

namespace product_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IEnumerable<Book> Books;

        public BooksController()
        {
            Books = BookFactoryHelper.CreateBooks();
        }

        [HttpGet()]
        public IEnumerable<Book> Get()
        {
            return Books;
        }

        [HttpGet("{code:guid}")]
        public Book Get(Guid code)
        {
            return Books.Where(b => b.Code == code).SingleOrDefault();
        }
    }
}