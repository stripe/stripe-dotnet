// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferTo : StripeEntity<OutboundTransferTo>
    {
        /// <summary>
        /// The monetary amount being credited to the destination.
        /// </summary>
        [JsonProperty("credited")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credited")]
#endif
        public V2.Amount Credited { get; set; }

        /// <summary>
        /// The payout method which the OutboundTransfer uses to send payout.
        /// </summary>
        [JsonProperty("payout_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method")]
#endif
        public string PayoutMethod { get; set; }
    }
}
