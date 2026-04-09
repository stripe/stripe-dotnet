// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedTokenNextAction : StripeEntity<IssuedTokenNextAction>
    {
        /// <summary>
        /// Specifies the type of next action required. Determines which child attribute contains
        /// action details.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Contains details for handling the next action using Stripe.js, iOS, or Android SDKs.
        /// Present when <c>next_action.type</c> is <c>use_stripe_sdk</c>.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        [STJS.JsonPropertyName("use_stripe_sdk")]
        public IssuedTokenNextActionUseStripeSdk UseStripeSdk { get; set; }
    }
}
