namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
