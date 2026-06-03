// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailOverride : StripeEntity<ContractContractLineDetailOverride>
    {
        /// <summary>
        /// Timestamp to indicate when the override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractContractLineDetailOverrideEndsAt EndsAt { get; set; }

        /// <summary>
        /// Service action override details.
        /// </summary>
        [JsonProperty("service_action")]
        [STJS.JsonPropertyName("service_action")]
        public ContractContractLineDetailOverrideServiceAction ServiceAction { get; set; }

        /// <summary>
        /// Timestamp to indicate when the override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractContractLineDetailOverrideStartsAt StartsAt { get; set; }

        /// <summary>
        /// The type of the override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
