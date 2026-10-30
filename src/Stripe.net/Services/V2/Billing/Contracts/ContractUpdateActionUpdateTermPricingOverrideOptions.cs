// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionUpdateTermPricingOverrideOptions : INestedOptions
    {
        /// <summary>
        /// Omission leaves the end unchanged; never requests an open end.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdateActionUpdateTermPricingOverrideEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// Can change only before the override starts. Accepts timestamp or now.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdateActionUpdateTermPricingOverrideStartsAtOptions StartsAt { get; set; }
    }
}
