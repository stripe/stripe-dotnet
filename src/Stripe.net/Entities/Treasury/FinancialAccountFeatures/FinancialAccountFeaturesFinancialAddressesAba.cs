// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFeaturesFinancialAddressesAba : StripeEntity<FinancialAccountFeaturesFinancialAddressesAba>
    {
        /// <summary>
        /// Requested bank partner for this Financial Account.
        /// One of: <c>evolve</c>, <c>fifth_third</c>, or <c>goldman_sachs</c>.
        /// </summary>
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }

        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Whether the Feature is operational.
        /// One of: <c>active</c>, <c>pending</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details; includes at least one entry when the status is not <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public List<FinancialAccountFeaturesFinancialAddressesAbaStatusDetail> StatusDetails { get; set; }
    }
}
