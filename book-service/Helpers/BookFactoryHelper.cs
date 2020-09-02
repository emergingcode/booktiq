using System;
using System.Collections.Generic;

using BookService.Models;

namespace BookService.Helpers
{
    public static class BookFactoryHelper
    {
        public static List<Book> CreateBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Code = Guid.Parse("3872339b-5556-4c94-b7ca-2cc8abde32d8"),
                    Title = "Em busca de nós mesmos",
                    TotalPages = 400,
                    ISBN = "978-8568014455",
                    Year = 2017,
                    Language = "Português",
                    Author = "Clóvis de Barros Filho & Pedro Calabrez"
                },
                new Book
                {
                    Code = Guid.Parse("6ef14d71-cd31-4c94-b88d-9d2dc26e3fb1"),
                    Title = "Astrofísica para apressados",
                    TotalPages = 192,
                    ISBN = "978-8542210996",
                    Year = 2017,
                    Language = "Português",
                    Author = "Neil Degrasse Tyson"
                },
                new Book
                {
                    Code = Guid.Parse("24eca492-67f3-4dac-a66e-1643bc6766e8"),
                    Title = "21 lições para o século 21",
                    TotalPages = 432,
                    ISBN = "978-8535930917",
                    Year = 2018,
                    Language = "Português",
                    Author = "Yuval Noah Harari"
                },
                new Book
                {
                    Code = Guid.Parse("2307feb3-d6e2-4758-968f-069833510018"),
                    Title = "Peopleware: Productive Projects and Teams",
                    TotalPages = 273,
                    ISBN = "978-8535930917",
                    Year = 2018,
                    Language = "Português",
                    Author = "Tom DeMarco & Tim Lister"
                },
                new Book
                {
                    Code = Guid.Parse("22d1e9b8-af4e-4859-a55b-5c6fd573736a"),
                    Title = "He: Understanding Masculine Psychology",
                    TotalPages = 98,
                    ISBN = "",
                    Year = 2009,
                    Language = "Inglês",
                    Author = "Robert A. Johnson"
                }
            };
        }
    }
}