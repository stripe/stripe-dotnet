// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesFinancialAddressesAba : StripeEntity<FinancialAccountFeaturesFinancialAddressesAba>
    {
        /// <summary>
        /// Requested bank partner for this Financial Account.
        /// One of: <c>evolve</c>, <c>fifth_third</c>, or <c>goldman_sachs</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Whether the Feature is operational.
        /// One of: <c>active</c>, <c>pending</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details; includes at least one entry when the status is not <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
        public List<FinancialAccountFeaturesFinancialAddressesAbaStatusDetail> StatusDetails { get; set; }
    }
}
