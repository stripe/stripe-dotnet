// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditNetworkDetails : StripeEntity<ReceivedCreditNetworkDetails>
    {
        /// <summary>
        /// Details about an ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public ReceivedCreditNetworkDetailsAch Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
