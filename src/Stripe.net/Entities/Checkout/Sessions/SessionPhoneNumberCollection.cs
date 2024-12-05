// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPhoneNumberCollection : StripeEntity<SessionPhoneNumberCollection>
    {
        /// <summary>
        /// Indicates whether phone number collection is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
