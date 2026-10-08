// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationFlexibleCredentialSecondaryCredential : StripeEntity<AuthorizationFlexibleCredentialSecondaryCredential>
    {
        /// <summary>
        /// The funding source that this credential can support.
        /// One of: <c>credit</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// Unique reference of this credential within this array.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
