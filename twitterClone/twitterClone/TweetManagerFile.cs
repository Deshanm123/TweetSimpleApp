using System;

 namespace twitterClone
{
    public class TweetManagerFile
    {
     public string filename = "tweets.txt";

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error 101: Tweeet must do not exceed 140 characters";

            if (TweetCounter() >= GetTweets().Length)
                return " Error 104:  Max Tweeets reached.";

            System.IO.File.AppendAllLines(filename,new string[] {tweet});
            //create a file if it is not exist otherwise add one tweet and close
            return "Posted Tweet Successfully";
        }
        //return the number of tweets
         public int TweetCounter()
        {
            return System.IO.File.ReadAllLines(filename).Length;
            //arr.length
        }


        //return array of tweeets 
         public string[] GetTweets()
        {
            return System.IO.File.ReadAllLines(filename);
            //creating a array
        }
    }
}
