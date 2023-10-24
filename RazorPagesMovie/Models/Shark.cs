using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Shark
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}