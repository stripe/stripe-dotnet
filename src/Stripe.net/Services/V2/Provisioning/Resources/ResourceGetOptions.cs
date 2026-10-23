// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ResourceGetOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response. Requesting configuration only populates
        /// names for a complete Resource with an available, unexpired configuration. Missing
        /// configuration is returned as null; authorization, dependency, malformed-data, and limit
        /// failures remain errors.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
