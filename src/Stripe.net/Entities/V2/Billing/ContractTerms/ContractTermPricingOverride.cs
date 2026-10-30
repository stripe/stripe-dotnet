// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermPricingOverride : StripeEntity<ContractTermPricingOverride>
    {
        /// <summary>
        /// Recurring or ad_hoc_product terms selected by this override. An override without
        /// criteria applies to all recurring and ad_hoc_product terms.
        /// </summary>
        [JsonProperty("criteria")]
        [STJS.JsonPropertyName("criteria")]
        public List<ContractTermPricingOverrideCriterion> Criteria { get; set; }

        /// <summary>
        /// The exclusive end of the validity window. Null for an open end.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractTermPricingOverrideEndsAt EndsAt { get; set; }

        /// <summary>
        /// Present when type is multiply.
        /// </summary>
        [JsonProperty("multiply")]
        [STJS.JsonPropertyName("multiply")]
        public ContractTermPricingOverrideMultiply Multiply { get; set; }

        /// <summary>
        /// Present when type is overwrite.
        /// </summary>
        [JsonProperty("overwrite")]
        [STJS.JsonPropertyName("overwrite")]
        public ContractTermPricingOverrideOverwrite Overwrite { get; set; }

        /// <summary>
        /// Lower numbers win. Equal priorities resolve by display order; overrides do not stack.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// The inclusive start of the override's validity window.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractTermPricingOverrideStartsAt StartsAt { get; set; }

        /// <summary>
        /// The pricing operation.
        /// One of: <c>multiply</c>, or <c>overwrite</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
