// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionTotalDetails : StripeEntity<RequestedSessionTotalDetails>
    {
        /// <summary>
        /// The amount discount of the total details.
        /// </summary>
        [JsonProperty("amount_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_discount")]
#endif
        public long? AmountDiscount { get; set; }

        /// <summary>
        /// The amount fulfillment of the total details.
        /// </summary>
        [JsonProperty("amount_fulfillment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_fulfillment")]
#endif
        public long? AmountFulfillment { get; set; }

        /// <summary>
        /// The amount tax of the total details.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long? AmountTax { get; set; }
    }
}
