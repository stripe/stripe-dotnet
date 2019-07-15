namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        /// <summary>
        /// If the PaymentIntent’s supported payment method types include <c>card</c>, this hash
        /// contains the configurations that will be applied to each payment attempt of that type.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
