﻿using InstagramApi.Classes;
using InstagramApi.ResponseWrappers;

namespace InstagramApi.Converters
{
    internal class ConvertersFabric
    {
        internal static IObjectConverter<InstaPostList, InstaResponse> GetPostsConverter(InstaResponse instaresponse)
        {
            return new InstaPostsConverter {SourceObject = instaresponse};
        }

        internal static IObjectConverter<InstaUser, InstaResponseUser> GetUserConverter(InstaResponseUser instaresponse)
        {
            return new InstaUsersConverter {SourceObject = instaresponse};
        }

        public static IObjectConverter<InstaPost, InstaResponseItem> GetSinglePostConverter(InstaResponseItem instaresponse)
        {
            return new InstaPostConverter {SourceObject = instaresponse};
        }
    }
}