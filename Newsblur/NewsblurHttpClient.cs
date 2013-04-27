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

        public async Task<CodeResult> Login(string username, string password = null)
        {
            var paramdict = new Dictionary<string, string>();
            paramdict["username"] = username;
            if (password != null)
            {
                paramdict["password"] = password;
            }
            var content = new FormUrlEncodedContent(paramdict);
            var response = await PostAsync(new Uri(newsblurapi, "api/login"), content);
            return new JsonSerializer().Deserialize<CodeResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        public async Task<CodeResult> Logout()
        {
            var response = await PostAsync(new Uri(newsblurapi, "api/logout"), null);
            return new JsonSerializer().Deserialize<CodeResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        public async Task<CodeResult> Signup(string username, string password = null, string email = null)
        {
            var paramdict = new Dictionary<string, string>();
            paramdict["username"] = username;
            if (password != null)
            {
                paramdict["password"] = password;
            }
            if (email != null)
            {
                paramdict["email"] = email;
            }
            var content = new FormUrlEncodedContent(paramdict);
            var response = await PostAsync(new Uri(newsblurapi, "api/signup"), content);
            return new JsonSerializer().Deserialize<CodeResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }
    }
}
