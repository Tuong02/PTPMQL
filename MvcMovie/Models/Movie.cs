using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie;
public class Movie 
{
    public int Id { get; set; }
public string? Title { get; set; }
[DataType(DataType.Date)]
public DateTime ReleaseDate { get; set; }
public string? Genre { get; set; }
public decimal Price { get; set; }
}
