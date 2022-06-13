namespace Project3_jamesthew.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }

        public LoginModel()
        {
            
        }

        public LoginModel(string username, string password, bool remember)
        {
            this.Username = username;
            this.Password = password;
            this.Remember = remember;
        }
    }
}
