// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationChannelThreeRIOptions : INestedOptions
    {
        /// <summary>
        /// ID of a prior <c>Authentication</c>. For example, the first recurring transaction that
        /// was authenticated by the cardholder.
        /// </summary>
        [JsonProperty("previous_authentication")]
        [STJS.JsonPropertyName("previous_authentication")]
        public string PreviousAuthentication { get; set; }

        /// <summary>
        /// It provides additional information to the ACS to determine the best approach for
        /// handling a 3RI request.
        /// One of: <c>delayed_shipment</c>, <c>other_payment</c>, <c>recurring</c>, or
        /// <c>split_shipment</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
