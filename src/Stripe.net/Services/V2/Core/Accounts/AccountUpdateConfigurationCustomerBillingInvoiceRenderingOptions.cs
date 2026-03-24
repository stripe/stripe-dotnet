// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCustomerBillingInvoiceRenderingOptions : INestedOptions
    {
        /// <summary>
        /// Indicates whether displayed line item prices and amounts on invoice PDFs include
        /// inclusive tax amounts. Must be either <c>include_inclusive_tax</c> or
        /// <c>exclude_tax</c>.
        /// One of: <c>exclude_tax</c>, or <c>include_inclusive_tax</c>.
        /// </summary>
        [JsonProperty("amount_tax_display")]
        [STJS.JsonPropertyName("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }

        /// <summary>
        /// ID of the invoice rendering template to use for future invoices.
        /// </summary>
        [JsonProperty("template")]
        [STJS.JsonPropertyName("template")]
        public string Template { get; set; }
    }
}
