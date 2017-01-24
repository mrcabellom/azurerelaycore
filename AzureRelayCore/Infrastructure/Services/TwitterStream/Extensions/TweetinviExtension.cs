using AzureRelayCore.Domain.Tweets.Entities;
using Tweetinvi.Models;

namespace AzureRelayCore.Infrastructure.Services.TwitterStream.Extensions
{
    public static class TweetinviExtension
    {
        public static TweetInfo ToTweetInfo(this ITweet tweetinviModel)
        {
            return new TweetInfo()
            {
                UrlUserImage = tweetinviModel.CreatedBy.ProfileImageUrl400x400,
                Text = tweetinviModel.Text
            };
        }
    }
}
