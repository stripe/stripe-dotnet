// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionShippingCostTax : StripeEntity<SessionShippingCostTax>
    {
        /// <summary>
        /// Amount of tax applied for this rate.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Tax rates can be applied to <a
        /// href="https://stripe.com/invoicing/taxes/tax-rates">invoices</a>, <a
        /// href="https://stripe.com/billing/taxes/tax-rates">subscriptions</a> and <a
        /// href="https://stripe.com/payments/checkout/use-manual-tax-rates">Checkout Sessions</a>
        /// to collect tax.
        ///
        /// Related guide: <a href="https://stripe.com/billing/taxes/tax-rates">Tax rates</a>.
        /// </summary>
        [JsonProperty("rate")]
        [STJS.JsonPropertyName("rate")]
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
        [STJS.JsonPropertyName("taxability_reason")]
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
        [STJS.JsonPropertyName("taxable_amount")]
        public long? TaxableAmount { get; set; }
    }
}
