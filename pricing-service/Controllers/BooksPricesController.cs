using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using PricingService.Helpers;
using PricingService.Models;

namespace pricing_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksPricesController : ControllerBase
    {
        private readonly IEnumerable<BookPrice> BookPrices;

        public BooksPricesController()
        {
            BookPrices = BookPriceFactoryHelper.GenerateBookPrices();
        }

        [HttpGet]
        public IEnumerable<BookPrice> Get()
        {
            return BookPrices;
        }

        [HttpGet("{code:guid}")]
        public BookPrice Get(Guid code)
        {
            return BookPrices.Where(bp => bp.Code == code).SingleOrDefault();
        }
    }
}