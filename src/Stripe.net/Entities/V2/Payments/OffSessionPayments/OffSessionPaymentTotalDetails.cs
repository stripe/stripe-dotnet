// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentTotalDetails : StripeEntity<OffSessionPaymentTotalDetails>
    {
        /// <summary>
        /// The subtotal of the items, including any inclusive tax and excluding exclusive tax.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public V2.Amount AmountSubtotal { get; set; }

        /// <summary>
        /// The calculated tax amount, including zero. Null when automatic tax was disabled.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public V2.Amount AmountTax { get; set; }
    }
}
