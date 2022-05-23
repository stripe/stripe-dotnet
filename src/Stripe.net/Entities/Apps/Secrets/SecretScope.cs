// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;

    public class SecretScope : StripeEntity<SecretScope>
    {
        /// <summary>
        /// The secret scope type.
        /// One of: <c>account</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The user ID, if type is set to "user".
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }
    }
}
