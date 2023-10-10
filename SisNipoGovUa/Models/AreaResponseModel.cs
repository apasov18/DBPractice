using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DecentralizationGovUa.Models
{
    public class AreaResponseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public float Square { get; set; }
        public int Population { get; set; }

        [JsonProperty("local_community_count")]
        public int LocalCommunityCount { get; set; }

        [JsonProperty("percent_communities_from_area")]
        public float? PercentCommunitiesFromArea { get; set; }

        [JsonProperty("sum_communities_square")]
        public float? SumCommunitiesSquare { get; set; }



    }
}
