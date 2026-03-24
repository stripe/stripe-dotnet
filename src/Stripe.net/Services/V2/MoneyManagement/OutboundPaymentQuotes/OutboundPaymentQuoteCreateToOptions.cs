// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentQuoteCreateToOptions : INestedOptions
    {
        /// <summary>
        /// Describes the currency to send to the recipient. If included, this currency must match a
        /// currency supported by the destination. Can be omitted in the following cases: -
        /// destination only supports one currency - destination supports multiple currencies and
        /// one of the currencies matches the FA currency - destination supports multiple currencies
        /// and one of the currencies matches the presentment currency Note - when both FA currency
        /// and presentment currency are supported, we pick the FA currency to minimize FX.
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
        /// To which account the OutboundPayment is sent.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }
    }
}
