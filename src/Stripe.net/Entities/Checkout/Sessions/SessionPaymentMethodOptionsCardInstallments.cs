// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsCardInstallments : StripeEntity<SessionPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Indicates if installments are enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
