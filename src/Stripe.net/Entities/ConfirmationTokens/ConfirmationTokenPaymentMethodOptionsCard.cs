// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodOptionsCard : StripeEntity<ConfirmationTokenPaymentMethodOptionsCard>
    {
        /// <summary>
        /// The <c>cvc_update</c> Token collected from the Payment Element.
        /// </summary>
        [JsonProperty("cvc_token")]
        [STJS.JsonPropertyName("cvc_token")]
        public string CvcToken { get; set; }

        /// <summary>
        /// Installment configuration for payments.
        /// </summary>
        [JsonProperty("installments")]
        [STJS.JsonPropertyName("installments")]
        public ConfirmationTokenPaymentMethodOptionsCardInstallments Installments { get; set; }
    }
}
