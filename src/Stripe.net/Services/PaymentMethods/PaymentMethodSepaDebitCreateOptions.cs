namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodSepaDebitCreateOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}
