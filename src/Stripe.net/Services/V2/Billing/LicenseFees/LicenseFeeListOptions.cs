// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LicenseFeeListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by licensed item.
        /// </summary>
        [JsonProperty("licensed_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("licensed_item")]
#endif
        public string LicensedItem { get; set; }

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
