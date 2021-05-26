using Newtonsoft.Json.Linq;
using System;

namespace RobloxApiWrapper
{
    class RobloxFriend
    {
        public RobloxFriend(JToken json)
        {
            IsOnline = (bool)json["isOnline"];
            PresenceType = (string)json["presenceType"];
            IsDeleted = (bool)json["isDeleted"];
            FriendRequestRank = (string)json["friendRequestRank"];
            Description = (string)json["description"];
            Created = (DateTime)json["created"];
            IsBanned = (bool)json["isBanned"];
            Id = (string)json["id"];
            Name = (string)json["name"];
            DisplayName = (string)json["displayName"];
        }

        public bool IsOnline { get; }
        public string PresenceType { get; }
        public bool IsDeleted { get; }
        public string FriendRequestRank { get; }
        public string Description { get; }
        public DateTime Created { get; }
        public bool IsBanned { get; }
        public string Id { get; }
        public string Name { get; }
        public string DisplayName { get; }
    }
}
