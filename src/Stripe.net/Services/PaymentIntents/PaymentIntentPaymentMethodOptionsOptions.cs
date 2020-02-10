namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
