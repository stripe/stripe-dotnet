// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateContractLineOverrideOptions : INestedOptions
    {
        /// <summary>
        /// Timestamp to indicate when the override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreateContractLineOverrideEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// Service action override parameters. Required if <c>type</c> is <c>service_action</c>.
        /// </summary>
        [JsonProperty("service_action")]
        [STJS.JsonPropertyName("service_action")]
        public ContractCreateContractLineOverrideServiceActionOptions ServiceAction { get; set; }

        /// <summary>
        /// Timestamp to indicate when the override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreateContractLineOverrideStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The type of the override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
