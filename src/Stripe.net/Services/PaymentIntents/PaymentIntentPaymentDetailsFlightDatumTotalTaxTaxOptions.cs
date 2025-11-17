// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumTotalTaxTaxOptions : INestedOptions
    {
        /// <summary>
        /// Tax amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        [JsonProperty("rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate")]
#endif
        public long? Rate { get; set; }

        /// <summary>
        /// Type of tax.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
