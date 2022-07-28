using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class Class //Lớp
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public Subjects Subject { get; set; }
    public int SubjectId { get; set; }
    public virtual ICollection<Students> Student { get; set; }
}