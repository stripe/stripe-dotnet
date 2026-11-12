// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentAutomaticTax : StripeEntity<OffSessionPaymentAutomaticTax>
    {
        /// <summary>
        /// Whether automatic tax calculation is enabled for this OffSessionPayment.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account liable for tax. Null when automatic tax is disabled; otherwise, an object
        /// with type set to <c>self</c>, indicating the account making the API request.
        /// </summary>
        [JsonProperty("liability")]
        [STJS.JsonPropertyName("liability")]
        public OffSessionPaymentAutomaticTaxLiability Liability { get; set; }
    }
}
