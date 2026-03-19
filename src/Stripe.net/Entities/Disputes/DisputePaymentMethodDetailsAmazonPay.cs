// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputePaymentMethodDetailsAmazonPay : StripeEntity<DisputePaymentMethodDetailsAmazonPay>
    {
        /// <summary>
        /// The AmazonPay dispute type, chargeback or claim.
        /// One of: <c>chargeback</c>, or <c>claim</c>.
        /// </summary>
        [JsonProperty("dispute_type")]
        [STJS.JsonPropertyName("dispute_type")]
        public string DisputeType { get; set; }
    }
}
