using Microsoft.Extensions.Configuration;

namespace AspNetCoreFood
{
    public class Greeter : IGreeter
    {
        private IConfiguration _config;

        public Greeter(IConfiguration config)
        {
            _config = config;
        }

        public string SetMessageOfTheDay()
        {
            return _config["Greeting"];
        }
    }
}
