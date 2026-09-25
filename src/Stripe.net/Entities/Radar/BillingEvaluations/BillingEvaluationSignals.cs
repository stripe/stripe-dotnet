// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationSignals : StripeEntity<BillingEvaluationSignals>
    {
        /// <summary>
        /// Stripe Radar's assessment of the likelihood that the upcoming charge results in
        /// non-payment abuse.
        /// </summary>
        [JsonProperty("non_payment_abuse")]
        [STJS.JsonPropertyName("non_payment_abuse")]
        public BillingEvaluationSignalsNonPaymentAbuse NonPaymentAbuse { get; set; }
    }
}
