// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCard : StripeEntity<PaymentIntentPaymentMethodOptionsCard>
    {
        /// <summary>
        /// Installment details for this payment (Mexico only).
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
        public PaymentIntentPaymentMethodOptionsCardInstallments Installments { get; set; }

        /// <summary>
        /// Selected network to process this payment intent on. Depends on the available networks of
        /// the card attached to the payment intent. Can be only set confirm-time.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>mastercard</c>, <c>unionpay</c>, <c>unknown</c>, or
        /// <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// We strongly recommend that you rely on our SCA Engine to automatically prompt your
        /// customers for authentication based on risk level and <a
        /// href="https://stripe.com/docs/strong-customer-authentication">other requirements</a>.
        /// However, if you wish to request 3D Secure based on logic from your own fraud engine,
        /// provide this option. Permitted values include: <c>automatic</c> or <c>any</c>. If not
        /// provided, defaults to <c>automatic</c>. Read our guide on <a
        /// href="https://stripe.com/docs/payments/3d-secure#manual-three-ds">manually requesting 3D
        /// Secure</a> for more information on how this configuration interacts with Radar and our
        /// SCA Engine.
        /// One of: <c>any</c>, <c>automatic</c>, or <c>challenge_only</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
