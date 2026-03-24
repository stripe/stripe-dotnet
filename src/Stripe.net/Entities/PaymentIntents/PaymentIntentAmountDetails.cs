// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetails : StripeEntity<PaymentIntentAmountDetails>
    {
        /// <summary>
        /// The total discount applied on the transaction represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than 0.
        ///
        /// This field is mutually exclusive with the
        /// <c>amount_details[line_items][#][discount_amount]</c> field.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public PaymentIntentAmountDetailsError Error { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 200 line items.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public StripeList<PaymentIntentAmountDetailsLineItem> LineItems { get; set; }

        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public PaymentIntentAmountDetailsShipping Shipping { get; set; }

        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentAmountDetailsTax Tax { get; set; }

        [JsonProperty("tip")]
        [STJS.JsonPropertyName("tip")]
        public PaymentIntentAmountDetailsTip Tip { get; set; }
    }
}
