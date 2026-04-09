// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedTokenNextActionUseStripeSdk : StripeEntity<IssuedTokenNextActionUseStripeSdk>
    {
        /// <summary>
        /// A base64-encoded string used by Stripe.js and the iOS and Android client SDKs to handle
        /// the next action. Its content is subject to change.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
