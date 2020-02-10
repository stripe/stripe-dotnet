namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardInstallments : StripeEntity<ChargePaymentMethodDetailsCardInstallments>
    {
        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
