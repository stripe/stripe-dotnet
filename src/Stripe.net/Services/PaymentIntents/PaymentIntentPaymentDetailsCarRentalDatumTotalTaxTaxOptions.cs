// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumTotalTaxTaxOptions : INestedOptions
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
        /// Tax rate applied.
        /// </summary>
        [JsonProperty("rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate")]
#endif
        public long? Rate { get; set; }

        /// <summary>
        /// Type of tax applied.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
