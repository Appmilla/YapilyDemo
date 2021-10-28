namespace Appmilla.Yapily.Refit.Configuration
{
    public interface IYapilyConfiguration
    {
        public string Username { get; set; }
        
        public string Password { get; set; }

        public string GetAuthorization();
    }
    
    public class YapilyConfiguration : IYapilyConfiguration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string GetAuthorization()
        {
            return "Basic " + Base64Encode(Username + ":" + Password);
        }

        public static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }
    }
}