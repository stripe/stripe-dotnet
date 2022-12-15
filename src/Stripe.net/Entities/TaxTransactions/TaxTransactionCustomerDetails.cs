// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxTransactionCustomerDetails : StripeEntity<TaxTransactionCustomerDetails>
    {
        /// <summary>
        /// The customer's postal address (e.g., home or business location).
        /// </summary>
        [JsonProperty("address")]
        public TaxTransactionCustomerDetailsAddress Address { get; set; }

        /// <summary>
        /// The type of customer address provided.
        /// One of: <c>billing</c>, or <c>shipping</c>.
        /// </summary>
        [JsonProperty("address_source")]
        public string AddressSource { get; set; }

        /// <summary>
        /// The customer's IP address (IPv4 or IPv6).
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The customer's tax IDs (e.g., EU VAT numbers).
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<TaxTransactionCustomerDetailsTaxId> TaxIds { get; set; }
    }
}
