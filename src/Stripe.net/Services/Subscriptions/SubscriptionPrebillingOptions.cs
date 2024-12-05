// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// Whether to cancel or preserve <c>prebilling</c> if the subscription is updated during
        /// the prebilled period. The default value is <c>reset</c>.
        /// One of: <c>prebill</c>, or <c>reset</c>.
        /// </summary>
        [JsonProperty("update_behavior")]
        public string UpdateBehavior { get; set; }
    }
}
