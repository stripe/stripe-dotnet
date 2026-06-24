// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingLinePricingPriceDetailsPricingOverrideOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// When the override ends. Defaults to the pricing line's end if not specified.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreatePricingLinePricingPriceDetailsPricingOverrideEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// A user-provided lookup key to reference this override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Parameters for the overwrite_price override. Required if <c>type</c> is
        /// <c>overwrite_price</c>.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractCreatePricingLinePricingPriceDetailsPricingOverrideOverwritePriceOptions OverwritePrice { get; set; }

        /// <summary>
        /// The priority of this override relative to others. 0 is highest, 100 is lowest. Defaults
        /// to 50.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// When the override starts. Defaults to the pricing line's start if not specified.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreatePricingLinePricingPriceDetailsPricingOverrideStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The type of override. Currently only <c>overwrite_price</c> is supported.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
