// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditNetworkDetails : StripeEntity<ReceivedCreditNetworkDetails>
    {
        /// <summary>
        /// Details about an ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public ReceivedCreditNetworkDetailsAch Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
