using System;
using System.Collections.Generic;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new Twitter
            {
                OAuthConsumerKey = "OAuth Consumer Key",
                OAuthConsumerSecret = "OAuth Consumer Secret"
            };
            IEnumerable<string> twitts = twitter.GetTwitts("karpach96", 10).Result;
            foreach (var t in twitts)
            {
                Console.WriteLine(t+"\n");
            }
            Console.ReadKey();
        }
    }
}
