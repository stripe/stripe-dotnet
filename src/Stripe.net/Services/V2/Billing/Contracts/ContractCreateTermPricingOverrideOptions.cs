// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateTermPricingOverrideOptions : INestedOptions
    {
        /// <summary>
        /// Optional criteria selecting recurring or ad_hoc_product terms. If omitted, the override
        /// applies to all recurring and ad_hoc_product terms.
        /// </summary>
        [JsonProperty("criteria")]
        [STJS.JsonPropertyName("criteria")]
        public List<ContractCreateTermPricingOverrideCriterionOptions> Criteria { get; set; }

        /// <summary>
        /// The exclusive end. Omitted means open-ended.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreateTermPricingOverrideEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// Required when type is multiply.
        /// </summary>
        [JsonProperty("multiply")]
        [STJS.JsonPropertyName("multiply")]
        public ContractCreateTermPricingOverrideMultiplyOptions Multiply { get; set; }

        /// <summary>
        /// Required when type is overwrite.
        /// </summary>
        [JsonProperty("overwrite")]
        [STJS.JsonPropertyName("overwrite")]
        public ContractCreateTermPricingOverrideOverwriteOptions Overwrite { get; set; }

        /// <summary>
        /// Lower numbers win; defaults to 50.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// The inclusive start of the validity window.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreateTermPricingOverrideStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The pricing operation. Exactly one matching pricing payload is required.
        /// One of: <c>multiply</c>, or <c>overwrite</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
