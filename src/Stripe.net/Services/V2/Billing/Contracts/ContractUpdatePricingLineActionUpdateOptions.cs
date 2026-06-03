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
        /// The updated end time for the pricing line.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionUpdateEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The ID of the pricing line.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The updated start time for the pricing line.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionUpdateStartsAtOptions StartsAt { get; set; }
    }
}
