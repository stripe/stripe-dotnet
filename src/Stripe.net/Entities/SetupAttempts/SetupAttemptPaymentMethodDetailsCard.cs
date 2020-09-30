// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptPaymentMethodDetailsCard : StripeEntity<SetupAttemptPaymentMethodDetailsCard>
    {
        /// <summary>
        /// Populated if this authorization used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public SetupAttemptPaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }
    }
}
