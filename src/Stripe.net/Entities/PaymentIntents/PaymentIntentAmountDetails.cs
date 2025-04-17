// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetails : StripeEntity<PaymentIntentAmountDetails>
    {
        /// <summary>
        /// The amount an item was discounted for.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long DiscountAmount { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 100 line items.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public StripeList<PaymentIntentAmountDetailsLineItem> LineItems { get; set; }

        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public PaymentIntentAmountDetailsShipping Shipping { get; set; }

        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentAmountDetailsTax Tax { get; set; }

        [JsonProperty("tip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tip")]
#endif
        public PaymentIntentAmountDetailsTip Tip { get; set; }
    }
}
