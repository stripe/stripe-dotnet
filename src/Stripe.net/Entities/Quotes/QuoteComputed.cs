// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteComputed : StripeEntity<QuoteComputed>
    {
        /// <summary>
        /// The definitive totals and line items the customer will be charged on a recurring basis.
        /// Takes into account the line items with recurring prices and discounts with
        /// <c>duration=forever</c> coupons only. Defaults to <c>null</c> if no inputted line items
        /// with recurring prices.
        /// </summary>
        [JsonProperty("recurring")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recurring")]
#endif
        public QuoteComputedRecurring Recurring { get; set; }

        [JsonProperty("upfront")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("upfront")]
#endif
        public QuoteComputedUpfront Upfront { get; set; }
    }
}
