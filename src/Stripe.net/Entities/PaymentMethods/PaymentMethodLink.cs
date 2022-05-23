// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodLink : StripeEntity<PaymentMethodLink>
    {
        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Token used for persistent Link logins.
        /// </summary>
        [JsonProperty("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
