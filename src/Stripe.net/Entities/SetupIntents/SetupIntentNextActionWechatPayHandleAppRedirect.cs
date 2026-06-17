// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentNextActionWechatPayHandleAppRedirect : StripeEntity<SetupIntentNextActionWechatPayHandleAppRedirect>
    {
        /// <summary>
        /// Session ID of the WeChat Pay signing session.
        /// </summary>
        [JsonProperty("session_id")]
        [STJS.JsonPropertyName("session_id")]
        public string SessionId { get; set; }
    }
}
