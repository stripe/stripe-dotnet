// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineEndsAtDiscountEnd : StripeEntity<QuoteLineEndsAtDiscountEnd>
    {
        /// <summary>
        /// The ID of a specific discount.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
