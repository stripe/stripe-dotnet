namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
