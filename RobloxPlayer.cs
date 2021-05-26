using Newtonsoft.Json.Linq;
using System;

namespace RobloxApiWrapper
{
    class RobloxPlayer
    {
        public RobloxPlayer(JToken json)
        {
            Description = (string)json["description"];
            Created = (DateTime)json["created"];
            IsBanned = (bool)json["isBanned"];
            Id = (string)json["id"];
            Name = (string)json["name"];
            DisplayName = (string)json["displayName"];
        }
        public string Description { get; }
        public DateTime Created { get; }
        public bool IsBanned { get; }
        public string Id { get; }
        public string Name { get; }
        public string DisplayName { get; }
    }
}
