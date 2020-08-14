namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdown : StripeEntity<SessionTotalDetailsBreakdown>
    {
        [JsonProperty("discounts")]
        public List<SessionTotalDetailsBreakdownDiscount> Discounts { get; set; }

        [JsonProperty("taxes")]
        public List<SessionTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
