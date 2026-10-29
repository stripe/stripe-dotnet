// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentEstimatedFeeTaxAmount : StripeEntity<PayoutIntentEstimatedFeeTaxAmount>
    {
        /// <summary>
        /// Currency code.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Tax amount value represented as a decimal string in major units.
        /// </summary>
        [JsonProperty("value_decimal")]
        [STJS.JsonPropertyName("value_decimal")]
        public string ValueDecimal { get; set; }
    }
}
