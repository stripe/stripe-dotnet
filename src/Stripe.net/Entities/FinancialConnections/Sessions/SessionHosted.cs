// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionHosted : StripeEntity<SessionHosted>
    {
        /// <summary>
        /// How the user enters the hosted flow. You can only use the values <c>email</c> and
        /// <c>url</c> if you provide <c>relink_options</c>.
        /// One of: <c>email</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("delivery_method")]
        [STJS.JsonPropertyName("delivery_method")]
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they link their accounts or cancel this
        /// Session. This parameter is required if <c>ui_mode</c> is <c>hosted</c>.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
