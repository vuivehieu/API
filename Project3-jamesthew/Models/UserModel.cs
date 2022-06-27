using Microsoft.AspNetCore.Identity;

namespace Project3_jamesthew.Entitites
{
public class UserModel
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
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

/*       public UserEntity()
    {
        
    }*/
}

}


