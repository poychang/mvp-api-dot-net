// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MVP.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Technology
    {
        /// <summary>
        /// Initializes a new instance of the Technology class.
        /// </summary>
        public Technology() { }

        /// <summary>
        /// Initializes a new instance of the Technology class.
        /// </summary>
        public Technology(Guid? technologyId = default(Guid?), string name = default(string), AwardCategory category = default(AwardCategory), int? statuscode = default(int?), bool? active = default(bool?))
        {
            TechnologyId = technologyId;
            Name = name;
            Category = category;
            Statuscode = statuscode;
            Active = active;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TechnologyId")]
        public Guid? TechnologyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public AwardCategory Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

    }
}
