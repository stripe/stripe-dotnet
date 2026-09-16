// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetailsCard : StripeEntity<OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetailsCard>
    {
        /// <summary>
        /// Authorization code returned by the card network.
        /// </summary>
        [JsonProperty("authorization_code")]
        [STJS.JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Stripe decline code for the latest payment attempt.
        /// </summary>
        [JsonProperty("decline_code")]
        [STJS.JsonPropertyName("decline_code")]
        public string DeclineCode { get; set; }

        /// <summary>
        /// Advice code returned by the card network.
        /// </summary>
        [JsonProperty("network_advice_code")]
        [STJS.JsonPropertyName("network_advice_code")]
        public string NetworkAdviceCode { get; set; }

        /// <summary>
        /// Decline code returned by the card network.
        /// </summary>
        [JsonProperty("network_decline_code")]
        [STJS.JsonPropertyName("network_decline_code")]
        public string NetworkDeclineCode { get; set; }
    }
}
