using Microsoft.AspNetCore.Identity;

namespace Project3_jamesthew.Entitites
{
public class UserEntity : IdentityUser
{
/*       public UserEntity(string fullName)
    {
        FullName = fullName;
    }

    public UserEntity(string userName, string fullName) : base(userName)
    {
        FullName = fullName;
    }*/

    public string FullName { get; set; }

/*       public UserEntity()
    {
        
    }*/
}

}


