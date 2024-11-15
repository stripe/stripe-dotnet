// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputePaymentMethodDetailsAmazonPay : StripeEntity<DisputePaymentMethodDetailsAmazonPay>
    {
        /// <summary>
        /// The AmazonPay dispute type, chargeback or claim.
        /// One of: <c>chargeback</c>, or <c>claim</c>.
        /// </summary>
        [JsonProperty("dispute_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute_type")]
#endif

        public string DisputeType { get; set; }
    }
}
