using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RobloxApiWrapper
{
    class RobloxSearchResult
    {
        public RobloxSearchResult(JToken json)
        {
            List<string> usernames = new List<string>();
            foreach (var username in json["previousUsernames"])
            {
                usernames.Add((string)username);
            }
            PreviousUsernames = usernames.AsReadOnly();
            Id = (string)json["id"];
            Name = (string)json["name"];
            DisplayName = (string)json["displayName"];
        }
        public RobloxSearchResult()
        {
            PreviousUsernames = null;
            Id = null;
            Name = null;
            DisplayName = null;
        }
        public IReadOnlyList<string> PreviousUsernames { get; }
        public string Id { get; }
        public string Name { get; }
        public string DisplayName { get; }
    }
}
