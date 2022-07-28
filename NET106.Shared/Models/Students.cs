using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class Students //Sinh Viên
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public bool Sex { get; set; }
    public DateTime StartDay { get; set; }
    public DateTime EndDay { get; set; }
    public Class Class { get; set; }
    public int ClassId { get; set; }
    public ICollection<Point> Point { get; set; }
}