namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
