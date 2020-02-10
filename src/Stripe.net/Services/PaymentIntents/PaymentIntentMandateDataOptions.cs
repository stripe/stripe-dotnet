namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentMandateDataOptions : INestedOptions
    {
        [JsonProperty("customer_acceptance")]
        public PaymentIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
