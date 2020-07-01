using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClone
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            TweetManagerFile TweetMsg = new TweetManagerFile();
          
           do
            {
                Console.WriteLine("\n--- Main Menue---");
                Console.WriteLine("1.View All Tweeets");
                Console.WriteLine("2.Post New Tweet");
                Console.WriteLine("3.Exit");

                choice = Console.ReadLine();
                Console.Write(" \n You have Entered\n", choice);
                if (choice == "1")
                {
                    for (int i = 0; i < TweetMsg.TweetCounter(); i++)
                    {
                        Console.WriteLine("Tweet #{0} : {1}", i+1,TweetMsg.GetTweets()[i]);
                        //GetTweeets return the array of msgs
                    }
                }
                if (choice == "2")
                {
                    Console.WriteLine(" Enter  your tweet:");
                    string tweet = Console.ReadLine();
                   
                   // tweets[tweetCounter++] = tweet;
                   string msg= TweetMsg.PostTweet(tweet);
                    Console.WriteLine(msg);
                    
                }
            } while (choice != "3");
        }
    }
}
