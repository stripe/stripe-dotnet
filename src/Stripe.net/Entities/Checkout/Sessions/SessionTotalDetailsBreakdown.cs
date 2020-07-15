namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdown : StripeEntity<SessionTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated line item discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<SessionTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated line item tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<SessionTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
