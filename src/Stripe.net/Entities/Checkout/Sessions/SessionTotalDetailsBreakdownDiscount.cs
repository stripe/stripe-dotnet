namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdownDiscount : StripeEntity<SessionTotalDetailsBreakdownDiscount>
    {
        /// <summary>
        /// The amount discounted.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The discount applied.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }
    }
}
