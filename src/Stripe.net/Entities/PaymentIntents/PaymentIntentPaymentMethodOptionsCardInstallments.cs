namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCardInstallments : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallments>
    {
        [JsonProperty("available_plans")]
        public List<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan> AvailablePlans { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
