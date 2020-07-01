namespace twitterClone
{
    public class TweetManagerMemory
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;
         public string PostTweet (string tweet)
        {
            if (tweets.Length > 140)
                return "Error 101: Tweeet must do not exceed 140 characters";

            if (tweetCounter >= tweets.Length)
                return " Error 104:  Max Tweeets reached.";

            tweets[tweetCounter++] = tweet;
            return "Tweeet posted successfully";
        }
        //return the number of tweets
         public int TweetCounter()
        {
            return tweetCounter;
        }


        //return array of tweeets 
         public string[] GetTweets()
        {
            return tweets;
        }
    }
}
