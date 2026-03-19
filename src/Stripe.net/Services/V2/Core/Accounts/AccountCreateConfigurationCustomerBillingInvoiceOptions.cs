// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCustomerBillingInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The list of up to 4 default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public List<AccountCreateConfigurationCustomerBillingInvoiceCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Default invoice footer.
        /// </summary>
        [JsonProperty("footer")]
        [STJS.JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Sequence number to use on the customer account's next invoice. Defaults to 1.
        /// </summary>
        [JsonProperty("next_sequence")]
        [STJS.JsonPropertyName("next_sequence")]
        public long? NextSequence { get; set; }

        /// <summary>
        /// Prefix used to generate unique invoice numbers. Must be 3-12 uppercase letters or
        /// numbers.
        /// </summary>
        [JsonProperty("prefix")]
        [STJS.JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Default invoice PDF rendering options.
        /// </summary>
        [JsonProperty("rendering")]
        [STJS.JsonPropertyName("rendering")]
        public AccountCreateConfigurationCustomerBillingInvoiceRenderingOptions Rendering { get; set; }
    }
}
