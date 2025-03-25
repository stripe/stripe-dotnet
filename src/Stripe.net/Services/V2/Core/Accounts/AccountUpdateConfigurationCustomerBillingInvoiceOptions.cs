// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCustomerBillingInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The list of up to 4 default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<AccountUpdateConfigurationCustomerBillingInvoiceCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer")]
#endif
        public string Footer { get; set; }

        /// <summary>
        /// The sequence to be used on the customer's next invoice. Defaults to 1.
        /// </summary>
        [JsonProperty("next_sequence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_sequence")]
#endif
        public long? NextSequence { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers. Must be 3–12
        /// uppercase letters or numbers.
        /// </summary>
        [JsonProperty("prefix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefix")]
#endif
        public string Prefix { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonProperty("rendering")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rendering")]
#endif
        public AccountUpdateConfigurationCustomerBillingInvoiceRenderingOptions Rendering { get; set; }
    }
}
