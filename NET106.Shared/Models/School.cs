using System.ComponentModel.DataAnnotations;

namespace NET106.Shared.Models;

public class School //Trường
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public virtual ICollection<Branch> Branchs { get; set; }
}