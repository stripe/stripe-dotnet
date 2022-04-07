// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteTotalDetailsBreakdown : StripeEntity<QuoteTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuoteTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<QuoteTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
