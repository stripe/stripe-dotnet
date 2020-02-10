namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
