namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCard : StripeEntity<PaymentIntentPaymentMethodOptionsCard>
    {
        /// <summary>
        /// We strongly recommend that you rely on our SCA engine to automatically prompt your
        /// customers for authentication based on risk level and other requirements. However, if
        /// you wish to request authentication based on logic from your own fraud engine, provide
        /// this option. Permitted values include: <c>automatic</c>, <c>any</c>, or
        /// <c>challenge_only</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
