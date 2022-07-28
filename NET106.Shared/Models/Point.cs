using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class Point //Điểm
{
    [Key] public int Id { get; set; }
    public Double Mark { get; set; }
    public Students Student { get; set; }
}