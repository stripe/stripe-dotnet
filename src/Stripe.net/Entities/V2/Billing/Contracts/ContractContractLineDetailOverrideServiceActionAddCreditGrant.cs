// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailOverrideServiceActionAddCreditGrant : StripeEntity<ContractContractLineDetailOverrideServiceActionAddCreditGrant>
    {
        /// <summary>
        /// The amount of the credit grant.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public ContractContractLineDetailOverrideServiceActionAddCreditGrantAmount Amount { get; set; }

        /// <summary>
        /// Defines the scope where the credit grant is applicable.
        /// </summary>
        [JsonProperty("applicability_config")]
        [STJS.JsonPropertyName("applicability_config")]
        public ContractContractLineDetailOverrideServiceActionAddCreditGrantApplicabilityConfig ApplicabilityConfig { get; set; }

        /// <summary>
        /// The category of the credit grant.
        /// One of: <c>paid</c>, or <c>promotional</c>.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The expiry configuration for the credit grant.
        /// </summary>
        [JsonProperty("expiry_config")]
        [STJS.JsonPropertyName("expiry_config")]
        public ContractContractLineDetailOverrideServiceActionAddCreditGrantExpiryConfig ExpiryConfig { get; set; }

        /// <summary>
        /// A descriptive name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The desired priority for applying this credit grant. The highest priority is 0 and the
        /// lowest is 100.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }
    }
}
