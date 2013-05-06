using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newsblur
{
    public class FeedsResult
    {
        public Dictionary<string, int>[] folders { get; set; }
        public bool authenticated { get; set; }
        public SocialProfile social_profile { get; set; }
        public int starred_count { get; set; }
        public string result { get; set; }
        public Dictionary<string, Feed> feeds { get; set; }
        public SocialServices social_services { get; set; }
        public object categories { get; set; }
        public SocialFeeds[] social_feeds { get; set; }
    }

    public class SocialProfile
    {
        public string website { get; set; }
        public int[] following_user_ids { get; set; }
        public int following_count { get; set; }
        public int shared_stories_count { get; set; }
        public bool _private { get; set; }
        public string large_photo_url { get; set; }
        public string id { get; set; }
        public string feed_address { get; set; }
        public int user_id { get; set; }
        public string feed_link { get; set; }
        public int[] follower_user_ids { get; set; }
        public string location { get; set; }
        public object popular_publishers { get; set; }
        public int follower_count { get; set; }
        public string username { get; set; }
        public string bio { get; set; }
        public int average_stories_per_month { get; set; }
        public string feed_title { get; set; }
        public string photo_service { get; set; }
        public int stories_last_month { get; set; }
        public string photo_url { get; set; }
        public int num_subscribers { get; set; }
        public bool _protected { get; set; }
    }

    public class Feed
    {
        public int subs { get; set; }
        public string favicon_url { get; set; }
        public bool is_push { get; set; }
        public int feed_opens { get; set; }
        public int id { get; set; }
        public int ps { get; set; }
        public bool subscribed { get; set; }
        public int updated_seconds_ago { get; set; }
        public bool favicon_fetching { get; set; }
        public int ng { get; set; }
        public int nt { get; set; }
        public bool not_yet_fetched { get; set; }
        public string updated { get; set; }
        public bool s3_icon { get; set; }
        public string feed_address { get; set; }
        public string feed_title { get; set; }
        public string favicon_fade { get; set; }
        public string favicon_color { get; set; }
        public bool active { get; set; }
        public bool fetched_once { get; set; }
        public string favicon_text_color { get; set; }
        public string feed_link { get; set; }
        public int num_subscribers { get; set; }
        public bool s3_page { get; set; }
        public string favicon_border { get; set; }
    }

    public class SocialServices
    {
        public Facebook facebook { get; set; }
        public Twitter twitter { get; set; }
        public Gravatar gravatar { get; set; }
        public Upload upload { get; set; }
    }

    public class Facebook
    {
        public bool syncing { get; set; }
        public object facebook_picture_url { get; set; }
        public object facebook_uid { get; set; }
    }

    public class Twitter
    {
        public object twitter_username { get; set; }
        public bool syncing { get; set; }
        public object twitter_picture_url { get; set; }
        public object twitter_uid { get; set; }
    }

    public class Gravatar
    {
        public string gravatar_picture_url { get; set; }
    }

    public class Upload
    {
        public object upload_picture_url { get; set; }
    }

    public class SocialFeeds
    {
        public string username { get; set; }
        public int ps { get; set; }
        public int user_id { get; set; }
        public int subscription_user_id { get; set; }
        public string feed_link { get; set; }
        public string feed_address { get; set; }
        public int feed_opens { get; set; }
        public int num_subscribers { get; set; }
        public int shared_stories_count { get; set; }
        public bool? _private { get; set; }
        public string feed_title { get; set; }
        public bool? _protected { get; set; }
        public string location { get; set; }
        public string photo_url { get; set; }
        public bool is_trained { get; set; }
        public int ng { get; set; }
        public int nt { get; set; }
        public string id { get; set; }
        public string page_url { get; set; }
    }
}
