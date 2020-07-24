namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemTax : StripeEntity<LineItemTax>
    {
        /// <summary>
        /// Amount of tax for this line item.
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
