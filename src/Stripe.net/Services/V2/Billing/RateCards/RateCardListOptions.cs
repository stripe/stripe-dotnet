// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCardListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter to active/inactive RateCards.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Filter by lookup keys. You can specify up to 10 lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }
    }
}
