using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twitterizer;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace URGE
{
    public class TwitterAPI
    {
        public OAuthTokenResponse authResponse { get; set; }

        public string key { get; set; }

        public string secret { get; set; }

        public TwitterAPI()
        {
            // set consumer key / secret of the application
            this.key = Properties.Settings.Default.key;
            this.secret = Properties.Settings.Default.secret;
        }

        public void auth()
        {
            OAuthTokenResponse tokenResponse = Twitterizer.OAuthUtility.GetRequestToken(this.key, this.secret, "oob");

            string target = "http://twitter.com/oauth/authorize?oauth_token=" + tokenResponse.Token;
                  
            Properties.Settings.Default.pin = "";
            
            Enter_PIN enterpin = new Enter_PIN(target);
            
            enterpin.ShowDialog();
            
            // user quited dialog without pin
            // the exception will be handled and will cause the Application to close
            if (Properties.Settings.Default.pin == "") {
                throw new TwitterizerException();
            }

            string pin = Properties.Settings.Default.pin;
            
            try
            {
                this.authResponse = OAuthUtility.GetAccessToken(this.key, this.secret, tokenResponse.Token, pin);
            } catch (ArgumentNullException e) {
                MessageBox.Show("Something went wrong. Maybe PIN was wrong?");
                this.auth();
            }
        }

        public bool sendTweet(string text)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = this.authResponse.Token;
            tokens.AccessTokenSecret = this.authResponse.TokenSecret;
            tokens.ConsumerKey = this.key;
            tokens.ConsumerSecret = this.secret;

            TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(tokens, text);
            if (tweetResponse.Result == RequestResult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> getGetCurrentTrends()
        {
            List<string> hashes = new List<string>();

            TwitterResponse<TwitterTrendCollection> col= TwitterTrend.Current();

            foreach (TwitterTrend trend in col.ResponseObject) {
                hashes.Add(trend.Name);
            }

            return hashes;
        }

        public List<string> getCurrentTweetsForHash(string hash)
        {
            List<string> tweets = new List<string>();
            SearchOptions options = new SearchOptions()
            {
                    PageNumber = 1,
                    NumberPerPage = 10
            };

            TwitterResponse<TwitterSearchResultCollection> result = TwitterSearch.Search(hash, options);
     
            foreach (TwitterSearchResult tweet in result.ResponseObject)
            {
                tweets.Add(this.getTweetFormated(tweet));
            }

            return tweets;
        }

        protected string getTweetFormated(TwitterSearchResult tweet) 
        {
            return string.Format(@"<div style=""color:#666; background-color: #eee; border: 1px solid #ccc; padding: 5px; margin-bottom: 5px; font-family: verdana; font-size: 12px;""><p><b style=""color:#000;""><a target=""_blank"" href=""http://twitter.com/#!/{0}""></b>{0}</b></a>: {1}</p></div>", tweet.FromUserScreenName, this.LinkifyText(tweet.Text));
        }

        protected string LinkifyText(string text)
        {
            return this.ConvertURLsToHyperlinks(text);
        }


        protected string ConvertURLsToHyperlinks(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var reg = new Regex(@"(?<!<\s*(?:a|img)\b[^<]*)(\b((http|https)://|www\.)[^ ]+\b)");
                return reg.Replace(input, new MatchEvaluator(ConvertUrlsMatchDelegate));

            }
            return input;
        }


        public static string ConvertUrlsMatchDelegate(Match m)
        {
            // add in additional http:// in front of the www. for the hyperlinks
            var additional = "";
            if (m.Value.StartsWith("www."))
            {
                additional = "http://";
            }
            return "<a href=\"" + additional + m.Value + "\" target=\"_blank\">" + m.Value + "</a>";
        }


    }
}
