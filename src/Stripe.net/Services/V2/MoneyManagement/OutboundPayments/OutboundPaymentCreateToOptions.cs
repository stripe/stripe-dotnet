// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentCreateToOptions : INestedOptions
    {
        /// <summary>
        /// Describes the currency to send to the recipient. If included, this currency must match a
        /// currency supported by the destination. Can be omitted in the following cases: -
        /// destination only supports one currency - destination supports multiple currencies and
        /// one matches <c>from.currency</c> - destination supports multiple currencies and one
        /// matches <c>amount.currency</c> When both <c>from.currency</c> and <c>amount.currency</c>
        /// are supported, Stripe selects <c>from.currency</c> to minimize currency conversion.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The payout method which the OutboundPayment uses to send payout.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// Payout method options for the OutboundPayment.
        /// </summary>
        [JsonProperty("payout_method_options")]
        [STJS.JsonPropertyName("payout_method_options")]
        public OutboundPaymentCreateToPayoutMethodOptionsOptions PayoutMethodOptions { get; set; }

        /// <summary>
        /// To which account the OutboundPayment is sent.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }
    }
}
