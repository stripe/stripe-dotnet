// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCardListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter to active/inactive RateCards.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Filter by lookup keys. You can specify up to 10 lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif
        public List<string> LookupKeys { get; set; }
    }
}
