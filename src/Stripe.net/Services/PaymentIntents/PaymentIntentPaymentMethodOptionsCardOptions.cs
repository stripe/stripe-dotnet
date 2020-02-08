namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        [JsonProperty("installments")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }

        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
