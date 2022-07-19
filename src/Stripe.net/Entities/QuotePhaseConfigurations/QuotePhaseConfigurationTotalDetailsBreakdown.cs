// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuotePhaseConfigurationTotalDetailsBreakdown : StripeEntity<QuotePhaseConfigurationTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuotePhaseConfigurationTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<QuotePhaseConfigurationTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
