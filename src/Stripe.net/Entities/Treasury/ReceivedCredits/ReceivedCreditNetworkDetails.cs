// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditNetworkDetails : StripeEntity<ReceivedCreditNetworkDetails>
    {
        /// <summary>
        /// Details about an ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
        public ReceivedCreditNetworkDetailsAch Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
