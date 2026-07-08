// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdateOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// Updated end time.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionUpdateEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The id of the pricing line.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Updated pricing configuration.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractUpdatePricingLineActionUpdatePricingOptions Pricing { get; set; }

        /// <summary>
        /// Updated start time.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionUpdateStartsAtOptions StartsAt { get; set; }
    }
}
