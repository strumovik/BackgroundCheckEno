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
            Created = (DateTime)json["created"];
        }
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string OwnerId { get; }
        public DateTime Created { get; }
    }
}
