namespace Stripe.Checkout
{
    using System;
    using Newtonsoft.Json;

    public class SessionPaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
