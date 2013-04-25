using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Newsblur
{
    public class NewsblurHttpClient : HttpClient
    {
        Uri newsblurapi;

        public NewsblurHttpClient(Uri newsblurapi)
            : base()
        {
            this.newsblurapi = newsblurapi;
        }

        public async Task<bool> Login(string username, string password = null)
        {
            var paramdict = new Dictionary<string, string>();
            paramdict["username"] = username;
            if (password != null)
            {
                paramdict["password"] = password;
            }
            var content = new FormUrlEncodedContent(paramdict);
            var response = await PostAsync(new Uri(newsblurapi, "api/login"), content);
            dynamic result = new JsonSerializer().Deserialize(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
            return result.code == 1;
        }
    }
}
