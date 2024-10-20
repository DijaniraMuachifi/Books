using System;
using System.Collections.Generic;
using System.Linq;
using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Data
{
    public static class BookSeeder
    {
        public static void SeedBooks(BookContext context)
        {
            // Verifica se já existem livros no banco de dados
            if (context.Books.Any())
            {
                return; // DB has been seeded
            }

            var books = new List<Book>
            {
                new Book
                {
                    Title = "O Senhor dos Anéis",
                    Author = "J.R.R. Tolkien",
                    Genre = "Health & Fitness",
                    LinkUrl = "https://document.desiringgod.org/living-in-the-light-en.pdf?ts=1646158538",
                    PublishedDate = new DateTime(1954, 7, 29),
                    Name="System"
                },
                new Book
                {
                    Title = "Coding Clean, Reliable, and Safe REST APIs with ASP.NET Core 8",
                    Author = "Anthony Giretti",
                    Genre = "Technology",
                    LinkUrl = "https://dl.ebooksworld.ir/books/Coding.Clean.Reliable.and.Safe.REST.APIs.with.ASP.NET.Core.8.9781484299784.EBooksWorld.ir.pdf",
                    PublishedDate = new DateTime(1949, 6, 8),
                     Name="System"
                },
                new Book
                {
                    Title = "The Essential Rumi",
                    Author = "COLEMAN BARKS",
                    Genre = "Relegion",
                    LinkUrl = "https://littlethingsaboutmeeh.wordpress.com/wp-content/uploads/2016/05/coleman-barks-the-essential-rumi.pdfo",
                    PublishedDate = new DateTime(1899, 8, 1),
                     Name="System"
                },
                new Book
                {
                    Title = "ASP.NET MVC is an open-source software from Microsoft",
                    Author = "George Orwell",
                    Genre = "Ficção Política",
                    LinkUrl = "https://example.com/a-revolucao-dos-bichos",
                    PublishedDate = new DateTime(1945, 8, 17),
                     Name="System"
                },
              
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
