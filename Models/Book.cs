using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string LinkUrl {get; set;}
    public string Name  { get; set; }

    
    private DateTime _publishedDate;
    public DateTime PublishedDate
    {
        get => _publishedDate;
        set => _publishedDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }
}
}
