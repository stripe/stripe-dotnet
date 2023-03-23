// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalculationCustomerDetails : StripeEntity<CalculationCustomerDetails>
    {
        /// <summary>
        /// The customer's postal address (for example, home or business location).
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
        /// The customer's tax IDs (for example, EU VAT numbers).
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<CalculationCustomerDetailsTaxId> TaxIds { get; set; }

        /// <summary>
        /// The taxability override used for taxation.
        /// One of: <c>customer_exempt</c>, <c>none</c>, or <c>reverse_charge</c>.
        /// </summary>
        [JsonProperty("taxability_override")]
        public string TaxabilityOverride { get; set; }
    }
}
