// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up an eMandate for cards issued in India.
        /// </summary>
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsCardMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// When specified, this parameter signals that a card has been collected as MOTO (Mail
        /// Order Telephone Order) and thus out of scope for SCA. This parameter can only be
        /// provided during confirmation.
        /// </summary>
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        /// <summary>
        /// Selected network to process this SetupIntent on. Depends on the available networks of
        /// the card attached to the SetupIntent. Can be only set confirm-time.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>interac</c>, <c>jcb</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>unknown</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// We strongly recommend that you rely on our SCA Engine to automatically prompt your
        /// customers for authentication based on risk level and <a
        /// href="https://stripe.com/docs/strong-customer-authentication">other requirements</a>.
        /// However, if you wish to request 3D Secure based on logic from your own fraud engine,
        /// provide this option. If not provided, this value defaults to <c>automatic</c>. Read our
        /// guide on <a
        /// href="https://stripe.com/docs/payments/3d-secure/authentication-flow#manual-three-ds">manually
        /// requesting 3D Secure</a> for more information on how this configuration interacts with
        /// Radar and our SCA Engine.
        /// One of: <c>any</c>, <c>automatic</c>, or <c>challenge</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }

        /// <summary>
        /// If 3D Secure authentication was performed with a third-party provider, the
        /// authentication details to use for this setup.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public SetupIntentPaymentMethodOptionsCardThreeDSecureOptions ThreeDSecure { get; set; }
    }
}
