// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionBuyerConsentsMarketingConsent : StripeEntity<RequestedSessionBuyerConsentsMarketingConsent>
    {
        /// <summary>
        /// The marketing consent channel.
        /// One of: <c>email</c>, or <c>sms</c>.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The consent status. 'granted' means the buyer opted in, 'none' means they did not.
        /// One of: <c>granted</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
