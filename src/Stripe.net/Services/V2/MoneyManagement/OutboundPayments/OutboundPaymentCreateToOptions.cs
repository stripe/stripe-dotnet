// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentCreateToOptions : INestedOptions
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

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
