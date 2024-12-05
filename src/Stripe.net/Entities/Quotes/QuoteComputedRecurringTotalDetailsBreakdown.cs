// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteComputedRecurringTotalDetailsBreakdown : StripeEntity<QuoteComputedRecurringTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuoteComputedRecurringTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<QuoteComputedRecurringTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
