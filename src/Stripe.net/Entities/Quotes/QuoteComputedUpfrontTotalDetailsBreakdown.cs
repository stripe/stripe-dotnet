// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteComputedUpfrontTotalDetailsBreakdown : StripeEntity<QuoteComputedUpfrontTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated line item discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuoteComputedUpfrontTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated line item tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<QuoteComputedUpfrontTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
