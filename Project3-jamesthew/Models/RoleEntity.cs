using System;

public class RoleEntity
{
    
    [Key]
    public int roleId { get; set; }
    [Column(TypeName = "varchar(30)")]
}
