// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsOption : StripeEntity<SessionItemMetronomeCommitCommitCommitOptionsOption>
    {
        /// <summary>
        /// The access amount for this option.
        /// </summary>
        [JsonProperty("access_amount")]
        [STJS.JsonPropertyName("access_amount")]
        public long AccessAmount { get; set; }

        /// <summary>
        /// Whether this option is pre-selected in the Checkout UI.
        /// </summary>
        [JsonProperty("default_option")]
        [STJS.JsonPropertyName("default_option")]
        public bool? DefaultOption { get; set; }
    }
}
