// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodOptionsCard : StripeEntity<ConfirmationTokenPaymentMethodOptionsCard>
    {
        /// <summary>
        /// The <c>cvc_update</c> Token collected from the Payment Element.
        /// </summary>
        [JsonProperty("cvc_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_token")]
#endif

        public string CvcToken { get; set; }
    }
}
