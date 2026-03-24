// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class LicenseFeeListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by licensed item.
        /// </summary>
        [JsonProperty("licensed_item")]
        [STJS.JsonPropertyName("licensed_item")]
        public string LicensedItem { get; set; }

        /// <summary>
        /// Filter by lookup keys. You can specify up to 10 lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }
    }
}
