// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsKonbini : StripeEntity<SessionPaymentMethodOptionsKonbini>
    {
        /// <summary>
        /// The number of calendar days (between 1 and 60) after which Konbini payment instructions
        /// will expire. For example, if a PaymentIntent is confirmed with Konbini and
        /// <c>expires_after_days</c> set to 2 on Monday JST, the instructions will expire on
        /// Wednesday 23:59:59 JST.
        /// </summary>
        [JsonProperty("expires_after_days")]
        public long? ExpiresAfterDays { get; set; }
    }
}
