// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodOptionsCard : StripeEntity<ConfirmationTokenPaymentMethodOptionsCard>
    {
        /// <summary>
        /// The <c>cvc_update</c> Token collected from the Payment Element.
        /// </summary>
        [JsonProperty("cvc_token")]
        public string CvcToken { get; set; }
    }
}
