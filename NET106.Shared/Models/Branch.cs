using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class Branch //Ngành
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public School School { get; set; }
    public int SchoolId { get; set; }

    public virtual ICollection<Subjects> Subjects { get; set; }
}