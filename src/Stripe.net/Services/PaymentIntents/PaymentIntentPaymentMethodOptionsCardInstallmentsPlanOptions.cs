// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions : INestedOptions
    {
        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is required. It represents the number of
        /// installment payments your customer will make to their credit card.
        /// </summary>
        [JsonProperty("count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("count")]
#endif
        public long? Count { get; set; }

        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is required. It represents the interval
        /// between installment payments your customer will make to their credit card. One of
        /// <c>month</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// Type of installment plan, one of <c>fixed_count</c>, <c>bonus</c>, or <c>revolving</c>.
        /// One of: <c>bonus</c>, <c>fixed_count</c>, or <c>revolving</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
