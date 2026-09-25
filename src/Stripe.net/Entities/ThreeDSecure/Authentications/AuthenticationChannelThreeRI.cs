// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationChannelThreeRI : StripeEntity<AuthenticationChannelThreeRI>
    {
        /// <summary>
        /// ID of the previous initial authenticated 3DS Authentication object.
        /// </summary>
        [JsonProperty("previous_authentication")]
        [STJS.JsonPropertyName("previous_authentication")]
        public string PreviousAuthentication { get; set; }

        /// <summary>
        /// Type of the 3RI Authentication.
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
