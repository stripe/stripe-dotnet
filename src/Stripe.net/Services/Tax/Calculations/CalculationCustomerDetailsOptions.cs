// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalculationCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's postal address (e.g., home or business location).
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

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
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<CalculationCustomerDetailsTaxIdOptions> TaxIds { get; set; }

        /// <summary>
        /// When <c>reverse_charge</c> is provided, the reverse charge rule is applied for taxation.
        /// When <c>customer_exempt</c> is sent, it treats the customer as tax exempt. Defaults to
        /// <c>none</c>.
        /// One of: <c>customer_exempt</c>, <c>none</c>, or <c>reverse_charge</c>.
        /// </summary>
        [JsonProperty("taxability_override")]
        public string TaxabilityOverride { get; set; }
    }
}
