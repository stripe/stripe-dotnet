// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitNetworkDetails : StripeEntity<ReceivedDebitNetworkDetails>
    {
        /// <summary>
        /// Details about an ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
        public ReceivedDebitNetworkDetailsAch Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
