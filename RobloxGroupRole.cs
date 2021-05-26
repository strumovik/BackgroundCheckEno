using Newtonsoft.Json.Linq;

namespace RobloxApiWrapper
{
    class RobloxGroupRole
    {
        public RobloxGroupRole(JToken json)
        {
            Id = (string)json["id"];
            Name = (string)json["name"];
            Rank = (int)json["rank"];
        }
        public string Id { get; }
        public string Name { get; }
        public int Rank { get; }
    }
}
