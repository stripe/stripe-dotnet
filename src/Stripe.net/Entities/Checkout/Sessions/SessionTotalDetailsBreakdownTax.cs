namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdownTax : StripeEntity<SessionTotalDetailsBreakdownTax>
    {
        /// <summary>
        /// Amount of tax applied for this rate.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The tax rate applied.
        /// </summary>
        [JsonProperty("rate")]
        public TaxRate Rate { get; set; }
    }
}
