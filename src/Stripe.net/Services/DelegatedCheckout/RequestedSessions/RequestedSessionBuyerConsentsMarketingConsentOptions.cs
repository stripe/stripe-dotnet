// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionBuyerConsentsMarketingConsentOptions : INestedOptions
    {
        /// <summary>
        /// The marketing consent channel.
        /// One of: <c>email</c>, or <c>sms</c>.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The consent status. Use 'granted' to indicate the buyer has opted in.
        /// One of: <c>granted</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
