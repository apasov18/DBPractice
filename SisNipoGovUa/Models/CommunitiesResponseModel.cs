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
    public class CommunitiesResponseModel
    {
        public string? Title { get; set; }
        public int? Id { get; set; }
        public DateTime Created {  get; set; }
        public double? Population { get; set; }
        public double? Square { get; set; }
        [JsonProperty("council_size")]
        public int? CouncilSize { get; set; }
        [JsonProperty("district_size")]
        public int? DistrictSize { get; set; }
        public string? Center { get; set; }
        public string Koatuu { get; set; }
        [JsonProperty("area_id")]
        public int? AreaId { get; set; }
        [JsonProperty("region_id")]
        public int? RegionId { get; set; }
    }
}
