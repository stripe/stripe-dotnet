// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionHosted : StripeEntity<SessionHosted>
    {
        /// <summary>
        /// How the user enters the hosted flow. You can only use the values <c>email</c> and
        /// <c>url</c> if you provide <c>relink_options</c>.
        /// One of: <c>email</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("delivery_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_method")]
#endif
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they link their accounts or cancel this
        /// Session. This parameter is required if <c>ui_mode</c> is <c>hosted</c>.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }
    }
}
