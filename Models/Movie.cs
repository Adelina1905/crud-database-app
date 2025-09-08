using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies1.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public DateOnly ReleaseDate { get; set; }
    [Required]
    public string? Genre { get; set; }
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Required]
    public decimal Price { get; set; }
}