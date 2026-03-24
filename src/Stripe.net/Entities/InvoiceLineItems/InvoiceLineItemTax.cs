// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemTax : StripeEntity<InvoiceLineItemTax>
    {
        /// <summary>
        /// The amount of the tax, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether this tax is inclusive or exclusive.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Additional details about the tax rate. Only present when <c>type</c> is
        /// <c>tax_rate_details</c>.
        /// </summary>
        [JsonProperty("tax_rate_details")]
        [STJS.JsonPropertyName("tax_rate_details")]
        public InvoiceLineItemTaxTaxRateDetails TaxRateDetails { get; set; }

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt. The possible
        /// values for this field may be extended as new tax rules are supported.
        /// One of: <c>customer_exempt</c>, <c>not_available</c>, <c>not_collecting</c>,
        /// <c>not_subject_to_tax</c>, <c>not_supported</c>, <c>portion_product_exempt</c>,
        /// <c>portion_reduced_rated</c>, <c>portion_standard_rated</c>, <c>product_exempt</c>,
        /// <c>product_exempt_holiday</c>, <c>proportionally_rated</c>, <c>reduced_rated</c>,
        /// <c>reverse_charge</c>, <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or
        /// <c>zero_rated</c>.
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

        /// <summary>
        /// The type of tax information.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
