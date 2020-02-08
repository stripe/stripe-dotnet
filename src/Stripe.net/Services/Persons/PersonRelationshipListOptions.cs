namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonRelationshipListOptions : INestedOptions
    {
        [JsonProperty("director")]
        public bool? Director { get; set; }

        [JsonProperty("executive")]
        public bool? Executive { get; set; }

        [JsonProperty("owner")]
        public bool? Owner { get; set; }

        [JsonProperty("representative")]
        public bool? Representative { get; set; }
    }
}
