// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's address. Learn about <a
        /// href="https://stripe.com/invoicing/taxes?dashboard-or-api=dashboard#set-up-customer">country-specific
        /// requirements for calculating tax</a>.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public InvoiceCustomerDetailsTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        [STJS.JsonPropertyName("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_ids")]
        [STJS.JsonPropertyName("tax_ids")]
        public List<InvoiceCustomerDetailsTaxIdOptions> TaxIds { get; set; }
    }
}
