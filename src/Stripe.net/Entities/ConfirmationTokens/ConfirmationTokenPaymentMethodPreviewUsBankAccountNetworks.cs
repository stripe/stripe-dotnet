// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewUsBankAccountNetworks : StripeEntity<ConfirmationTokenPaymentMethodPreviewUsBankAccountNetworks>
    {
        /// <summary>
        /// The preferred network.
        /// </summary>
        [JsonProperty("preferred")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred")]
#endif
        public string Preferred { get; set; }

        /// <summary>
        /// All supported networks.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("supported")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported")]
#endif
        public List<string> Supported { get; set; }
    }
}
