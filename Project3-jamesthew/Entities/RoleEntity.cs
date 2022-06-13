using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models;

public class RoleEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "varchar(20)")]
    public string RoleName { get; set; }
    public RoleEntity(int id, string roleName)
    {
        Id = id;
        RoleName = roleName;
    }
}