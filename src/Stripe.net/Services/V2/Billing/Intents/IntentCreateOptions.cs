// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Actions to be performed by this Billing Intent.
        /// </summary>
        [JsonProperty("actions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("actions")]
#endif
        public List<IntentCreateActionOptions> Actions { get; set; }

        /// <summary>
        /// ID of an existing Cadence to use.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }
    }
}
