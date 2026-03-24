// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumTotalExtraCharge : StripeEntity<PaymentIntentPaymentDetailsFlightDatumTotalExtraCharge>
    {
        /// <summary>
        /// Amount of the extra charge.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Type of extra charge.
        /// One of: <c>additional_fees</c>, <c>ancillary_service_charges</c>, or
        /// <c>exchange_fee</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
