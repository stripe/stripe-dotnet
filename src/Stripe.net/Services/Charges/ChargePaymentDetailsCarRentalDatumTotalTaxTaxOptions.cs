// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsCarRentalDatumTotalTaxTaxOptions : INestedOptions
    {
        /// <summary>
        /// Tax amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Tax rate applied.
        /// </summary>
        [JsonProperty("rate")]
        [STJS.JsonPropertyName("rate")]
        public long? Rate { get; set; }

        /// <summary>
        /// Type of tax applied.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
