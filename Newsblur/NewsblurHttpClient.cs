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

        // POST api/login
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

        // POST api/logout
        public async Task<CodeResult> Logout()
        {
            var response = await PostAsync(new Uri(newsblurapi, "api/logout"), null);
            return new JsonSerializer().Deserialize<CodeResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        // POST api/signup
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
        
        // GET reader/feeds
        public async Task<FeedsResult> GetFeeds(bool include_favicons = false, bool update_counts = false)
        {
            var response = await GetAsync(new Uri(newsblurapi, string.Format("reader/feeds?include_favicons={0}&update_counts={1}", include_favicons, update_counts)));
            return new JsonSerializer().Deserialize<FeedsResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        // GET reader/favicons
        public async Task<Dictionary<string, string>> GetFavicons()
        {
            var response = await GetAsync(new Uri(newsblurapi, "reader/favicons"));
            return new JsonSerializer().Deserialize<Dictionary<string, string>>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        // GET reader/refresh_counts
        public async Task<RefreshCountsResult> RefreshCounts()
        {
            var response = await GetAsync(new Uri(newsblurapi, "reader/refresh_counts"));
            return new JsonSerializer().Deserialize<RefreshCountsResult>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }
    }
}
