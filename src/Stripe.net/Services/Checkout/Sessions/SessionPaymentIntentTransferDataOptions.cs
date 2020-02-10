namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionPaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
