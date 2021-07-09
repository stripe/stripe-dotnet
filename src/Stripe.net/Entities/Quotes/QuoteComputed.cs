// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteComputed : StripeEntity<QuoteComputed>
    {
        /// <summary>
        /// The definitive totals and line items the customer will be charged on a recurring basis.
        /// Takes into account the line items with recurring prices and discounts with
        /// <c>duration=forever</c> coupons only. Defaults to <c>null</c> if no inputted line items
        /// with recurring prices.
        /// </summary>
        [JsonProperty("recurring")]
        public QuoteComputedRecurring Recurring { get; set; }

        [JsonProperty("upfront")]
        public QuoteComputedUpfront Upfront { get; set; }
    }
}
