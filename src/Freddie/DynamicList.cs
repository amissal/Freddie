namespace Freddie
{
    [Handles("listAbuseReports", typeof(ArrayParser))]
    [Handles("listActivity", typeof(ArrayParser))]
    [Handles("listClients", typeof(BooleanParser))]
    [Handles("listGrowthHistory", typeof(ArrayParser))]
    [Handles("listInterestGroupAdd", typeof(BooleanParser))]
    [Handles("listInterestGroupDel", typeof(BooleanParser))]
    [Handles("listInterestGroupUpdate", typeof(BooleanParser))]
    [Handles("listLocations", typeof(ArrayParser))]
    [Handles("listMemberActivity", typeof(ArrayParser))]
    [Handles("listMemberInfo", typeof(ArrayParser))]
    [Handles("listMembers", typeof(ArrayParser))]
    [Handles("listUpdateMember", typeof(BooleanParser))]
    [Handles("listStaticSegments", typeof(ArrayParser))]
    [Handles("listSubscribe", typeof(BooleanParser))]
    [Handles("lists", typeof(ObjectParser))]
    internal class DynamicList : DynamicBase
    {
        internal DynamicList(Endpoint endpoint) : base(endpoint)
        {
        }
    }
}