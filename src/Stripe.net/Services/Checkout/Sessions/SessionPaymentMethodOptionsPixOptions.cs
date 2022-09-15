// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// The number of seconds (between 10 and 1209600) after which Pix payment will expire.
        /// Defaults to 86400 seconds.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }
    }
}
