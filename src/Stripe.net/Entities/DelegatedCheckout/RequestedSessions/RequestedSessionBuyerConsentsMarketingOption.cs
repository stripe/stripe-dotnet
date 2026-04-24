// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionBuyerConsentsMarketingOption : StripeEntity<RequestedSessionBuyerConsentsMarketingOption>
    {
        /// <summary>
        /// The marketing channel type.
        /// One of: <c>email</c>, or <c>sms</c>.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The description of the marketing consent option.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The privacy policy URL for this marketing channel.
        /// </summary>
        [JsonProperty("privacy_policy_url")]
        [STJS.JsonPropertyName("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }
    }
}
