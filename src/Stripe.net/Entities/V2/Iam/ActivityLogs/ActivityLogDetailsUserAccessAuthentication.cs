// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccessAuthentication : StripeEntity<ActivityLogDetailsUserAccessAuthentication>
    {
        /// <summary>
        /// Primary authentication factor.
        /// </summary>
        [JsonProperty("primary_factor")]
        [STJS.JsonPropertyName("primary_factor")]
        public ActivityLogDetailsUserAccessAuthenticationPrimaryFactor PrimaryFactor { get; set; }

        /// <summary>
        /// Secondary authentication factors.
        /// </summary>
        [JsonProperty("secondary_factors")]
        [STJS.JsonPropertyName("secondary_factors")]
        public List<ActivityLogDetailsUserAccessAuthenticationSecondaryFactor> SecondaryFactors { get; set; }
    }
}
