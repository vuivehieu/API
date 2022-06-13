namespace Project3_jamesthew.Models
{
    public class ApplicationSettings
    {
        public ApplicationSettings(string jwtSecret)
        {
            JwtSecret = jwtSecret;
        }

        public string JwtSecret { get; set; }

    }
}
