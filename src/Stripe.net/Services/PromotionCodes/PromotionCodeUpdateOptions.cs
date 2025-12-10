// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PromotionCodeUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the promotion code is currently active. A promotion code can only be reactivated
        /// when the coupon is still valid and the promotion code is otherwise redeemable.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Settings that restrict the redemption of the promotion code.
        /// </summary>
        [JsonProperty("restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restrictions")]
#endif
        public PromotionCodeRestrictionsOptions Restrictions { get; set; }
    }
}
