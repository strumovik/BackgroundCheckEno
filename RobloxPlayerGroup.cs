using Newtonsoft.Json.Linq;

namespace RobloxApiWrapper
{
    class RobloxPlayerGroup
    {
        public RobloxPlayerGroup(JToken json)
        {

            var group = json["group"];
            var role = json["role"];

            RoleInGroup = new RobloxGroupRole(role);
            Id = (string)group["id"];
            Name = (string)group["name"];
            MemberCount = (int)group["memberCount"];
        }
        public string Id { get; }
        public string Name { get; }
        public int MemberCount { get; }
        public RobloxGroupRole RoleInGroup { get; }
    }
}
