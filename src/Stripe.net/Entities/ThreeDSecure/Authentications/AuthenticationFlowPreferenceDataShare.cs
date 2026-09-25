// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationFlowPreferenceDataShare : StripeEntity<AuthenticationFlowPreferenceDataShare>
    {
        /// <summary>
        /// Type of data share flow you requested for this 3DS Authentication.
        /// One of: <c>ds_specific</c>, or <c>emv_standard</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
