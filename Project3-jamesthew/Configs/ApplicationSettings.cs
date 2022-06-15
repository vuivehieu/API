namespace Project3_jamesthew.Configs
{
    public class ApplicationSettings
    {
        public ApplicationSettings(string jwtSecret)
        {
            JwtSecret = jwtSecret;
        }

        public string JwtSecret { get; set; }

        public ApplicationSettings()
        {

        }
    }

}
