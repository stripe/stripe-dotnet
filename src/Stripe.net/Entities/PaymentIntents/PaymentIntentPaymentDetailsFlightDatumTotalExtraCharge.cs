// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumTotalExtraCharge : StripeEntity<PaymentIntentPaymentDetailsFlightDatumTotalExtraCharge>
    {
        /// <summary>
        /// Amount of the extra charge.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Type of extra charge.
        /// One of: <c>additional_fees</c>, <c>ancillary_service_charges</c>, or
        /// <c>exchange_fee</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
