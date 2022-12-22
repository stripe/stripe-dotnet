// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalculationCustomerDetails : StripeEntity<CalculationCustomerDetails>
    {
        /// <summary>
        /// The customer's postal address (e.g., home or business location).
        /// </summary>
        [JsonProperty("address")]
        public CalculationCustomerDetailsAddress Address { get; set; }

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
        public List<CalculationCustomerDetailsTaxId> TaxIds { get; set; }
    }
}
