// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteShippingCostTax : StripeEntity<CreditNoteShippingCostTax>
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
        /// Related guide: <a href="https://stripe.com/docs/billing/taxes/tax-rates">Tax rates</a>.
        /// </summary>
        [JsonProperty("rate")]
        public TaxRate Rate { get; set; }

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt. The possible
        /// values for this field may be extended as new tax rules are supported.
        /// One of: <c>customer_exempt</c>, <c>not_collecting</c>, <c>not_subject_to_tax</c>,
        /// <c>not_supported</c>, <c>portion_product_exempt</c>, <c>portion_reduced_rated</c>,
        /// <c>portion_standard_rated</c>, <c>product_exempt</c>, <c>product_exempt_holiday</c>,
        /// <c>proportionally_rated</c>, <c>reduced_rated</c>, <c>reverse_charge</c>,
        /// <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or <c>zero_rated</c>.
        /// </summary>
        [JsonProperty("taxability_reason")]
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long? TaxableAmount { get; set; }
    }
}
