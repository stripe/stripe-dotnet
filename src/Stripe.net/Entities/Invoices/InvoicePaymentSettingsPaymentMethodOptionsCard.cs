// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCard : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCard>
    {
        /// <summary>
        /// We strongly recommend that you rely on our SCA Engine to automatically prompt your
        /// customers for authentication based on risk level and <a
        /// href="https://stripe.com/docs/strong-customer-authentication">other requirements</a>.
        /// However, if you wish to request 3D Secure based on logic from your own fraud engine,
        /// provide this option. Read our guide on <a
        /// href="https://stripe.com/docs/payments/3d-secure#manual-three-ds">manually requesting 3D
        /// Secure</a> for more information on how this configuration interacts with Radar and our
        /// SCA Engine.
        /// One of: <c>any</c>, or <c>automatic</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
