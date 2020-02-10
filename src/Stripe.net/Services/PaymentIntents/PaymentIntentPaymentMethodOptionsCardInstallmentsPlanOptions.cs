namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions : INestedOptions
    {
        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
