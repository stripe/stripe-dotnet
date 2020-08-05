namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PromotionCodeUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the promotion code is currently active. A promotion code can only be reactivated
        /// when the coupon is still valid and the promotion code is otherwise redeemable.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
