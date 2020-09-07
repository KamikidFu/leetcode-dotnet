using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1.Question
{
    public class Q535
    {
        public static void Run(string url)
        {
            Codec codec = new Codec();
            Console.WriteLine(codec.decode(codec.encode(url)) == url);
        }

        public class Codec
        {
            string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Hashtable map = new Hashtable();
            Random rand = new Random();

            private string getRandomKey()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 6; i++) {
                    sb.Append(alphabet[(rand.Next(62))]);
                }
                return sb.ToString();
            }
            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                var key = getRandomKey();
                while (map.ContainsKey(key))
                {
                    key = getRandomKey();
                }
                map.Add(key,longUrl);
                return "http://tinyurl.com/" + key;
            }

            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                return map[shortUrl.Replace("http://tinyurl.com/", "")].ToString();
            }
        }

    }
}