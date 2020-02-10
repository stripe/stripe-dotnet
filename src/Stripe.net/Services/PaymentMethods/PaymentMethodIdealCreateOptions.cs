namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodIdealCreateOptions : INestedOptions
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
