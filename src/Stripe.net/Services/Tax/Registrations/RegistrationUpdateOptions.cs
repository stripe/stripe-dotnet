// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Time at which the registration becomes active. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("active_from")]
        public long? ActiveFrom { get; set; }

        /// <summary>
        /// If set, the registration stops being active at this time. If not set, the registration
        /// will be active indefinitely. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }
    }
}
