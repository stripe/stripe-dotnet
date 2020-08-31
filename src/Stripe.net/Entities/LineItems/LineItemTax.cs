namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemTax : StripeEntity<LineItemTax>
    {
        /// <summary>
        /// Amount of tax applied for this rate.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Tax rates can be applied to <a
        /// href="https://stripe.com/docs/billing/invoices/tax-rates">invoices</a>, <a
        /// href="https://stripe.com/docs/billing/subscriptions/taxes">subscriptions</a> and <a
        /// href="https://stripe.com/docs/payments/checkout/set-up-a-subscription#tax-rates">Checkout
        /// Sessions</a> to collect tax.
        ///
        /// Related guide: <a href="https://stripe.com/docs/billing/taxes/tax-rates">Tax Rates</a>.
        /// </summary>
        [JsonProperty("rate")]
        public TaxRate Rate { get; set; }
    }
}
