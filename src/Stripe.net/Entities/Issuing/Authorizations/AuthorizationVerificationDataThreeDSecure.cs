namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationDataThreeDSecure : StripeEntity<AuthorizationVerificationDataThreeDSecure>
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
