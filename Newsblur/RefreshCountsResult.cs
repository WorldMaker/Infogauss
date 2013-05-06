using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newsblur
{
    public class RefreshCountsResult
    {
        public bool authenticated { get; set; }
        public string result { get; set; }
        public Dictionary<string, FeedCount> feeds { get; set; }
        public Dictionary<string, FeedCount> social_feeds { get; set; }
    }

    public class FeedCount
    {
        public string id { get; set; }
        public int ng { get; set; }
        public int nt { get; set; }
        public int ps { get; set; }
    }
}
