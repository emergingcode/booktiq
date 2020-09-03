using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

using api_gateway.Models;

using Microsoft.AspNetCore.Http;

using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace api_gateway.Aggregators
{
    public class BookDetailsAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var resultingAggregation = new ResultingAggregation<Book>();

            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var book = await responses[0].Items.DownstreamResponse().Content.ReadAsAsync<Book>();

                try
                {
                    var price = await responses[1].Items.DownstreamResponse().Content.ReadAsAsync<BookPrice>();
                    var rating = await responses[2].Items.DownstreamResponse().Content.ReadAsAsync<BookRating>();

                    book.Stars = rating.Stars;
                    book.Price = price.Price;

                    resultingAggregation.Ok(book);
                }
                catch (Exception)
                {
                    resultingAggregation.Partial(book, "There was an error when loading Book DownStreams.");
                }
            }
            catch (Exception)
            {
                resultingAggregation.Error("There was error when loading the book details.");
            }

            response.Content = new ObjectContent<ResultingAggregation<Book>>(resultingAggregation, new JsonMediaTypeFormatter());

            return new DownstreamResponse(response);
        }
    }
}