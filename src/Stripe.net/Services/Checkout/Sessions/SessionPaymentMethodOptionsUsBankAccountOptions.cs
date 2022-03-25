// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Verification method for the intent.
        /// One of: <c>automatic</c>, or <c>instant</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
