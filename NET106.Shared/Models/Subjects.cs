using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class Subjects //Môn học
{
    [Key]
    public int Id { get; set; }

    public string Code { get; set; }
    public string Name { get; set; }
    public Branch Branch { get; set; }
    public int BranchId { get; set; }
    public virtual ICollection<Class> Class { get; set; }
}