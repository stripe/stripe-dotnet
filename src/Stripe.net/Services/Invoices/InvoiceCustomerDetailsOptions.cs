// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonProperty("tax")]
        public InvoiceCustomerDetailsTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<InvoiceCustomerDetailsTaxIdOptions> TaxIds { get; set; }
    }
}
