// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalculationCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's postal address (for example, home or business location).
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
        /// The customer's tax IDs. Stripe Tax might consider a transaction with applicable tax IDs
        /// to be B2B, which might affect the tax calculation result. Stripe Tax doesn't validate
        /// tax IDs for correctness.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<CalculationCustomerDetailsTaxIdOptions> TaxIds { get; set; }

        /// <summary>
        /// Overrides the tax calculation result to allow you to not collect tax from your customer.
        /// Use this if you've manually checked your customer's tax exemptions. Prefer providing the
        /// customer's <c>tax_ids</c> where possible, which automatically determines whether
        /// <c>reverse_charge</c> applies.
        /// One of: <c>customer_exempt</c>, <c>none</c>, or <c>reverse_charge</c>.
        /// </summary>
        [JsonProperty("taxability_override")]
        public string TaxabilityOverride { get; set; }
    }
}
