// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BillSettingListOptions : V2.ListOptions
    {
        /// <summary>
        /// Only return the settings with these lookup_keys, if any exist. You can specify up to 10
        /// lookup_keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif
        public List<string> LookupKeys { get; set; }
    }
}
