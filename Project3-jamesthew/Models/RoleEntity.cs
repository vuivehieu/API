using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RoleEntity
{
    
    [Key]
    public int RoleId { get; set; }
    [Column(TypeName = "varchar(30)")]
    public string RoleName { get; set; }

    public RoleEntity()
    {
        
    }

    public RoleEntity(int roleId, string roleName)
    {
        RoleId = roleId;
        RoleName = roleName;
    }
}
