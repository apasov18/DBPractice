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
    public class RegionResponseModel
    {
        public string? Title { get; set; }

        [JsonProperty("area_id")]
        public int? AreaId { get; set; }
        public int? Id { get; set; }
        public double? Population { get; set; }

    }
}
