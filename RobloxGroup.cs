using Newtonsoft.Json.Linq;
using System;

namespace RobloxApiWrapper
{
    class RobloxGroup
    {
        public RobloxGroup(JToken json)
        {
            Id = (string)json["id"];
            Name = (string)json["name"];
            Description = (string)json["description"];
            MemberCount = (int)json["memberCount"];
            Created = (DateTime)json["created"];
        }
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string OwnerId { get; }
        public int MemberCount { get; }
        public DateTime Created { get; }
    }
}
