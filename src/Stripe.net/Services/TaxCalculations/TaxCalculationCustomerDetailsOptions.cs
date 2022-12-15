// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxCalculationCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's postal address (e.g., home or business location).
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The type of customer address provided. Required when using <c>address</c>.
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
        public List<TaxCalculationCustomerDetailsTaxIdOptions> TaxIds { get; set; }
    }
}
