namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationDataThreeDSecure : StripeEntity<AuthorizationVerificationDataThreeDSecure>
    {
        /// <summary>
        /// The outcome of the 3D Secure authentication request.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
