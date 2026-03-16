// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteTo : StripeEntity<OutboundPaymentQuoteTo>
    {
        /// <summary>
        /// The monetary amount being credited to the destination.
        /// </summary>
        [JsonProperty("credited")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credited")]
#endif
        public OutboundPaymentQuoteToCredited Credited { get; set; }

        /// <summary>
        /// The payout method which the OutboundPayment uses to send payout.
        /// </summary>
        [JsonProperty("payout_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method")]
#endif
        public string PayoutMethod { get; set; }

        /// <summary>
        /// To which account the OutboundPayment is sent.
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public string Recipient { get; set; }
    }
}
