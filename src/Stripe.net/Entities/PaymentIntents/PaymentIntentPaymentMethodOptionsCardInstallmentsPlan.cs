// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlan : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan>
    {
        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the number of installment payments
        /// your customer will make to their credit card.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the interval between installment
        /// payments your customer will make to their credit card. One of <c>month</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Type of installment plan, one of <c>fixed_count</c>, <c>bonus</c>, or <c>revolving</c>.
        /// One of: <c>bonus</c>, <c>fixed_count</c>, or <c>revolving</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
