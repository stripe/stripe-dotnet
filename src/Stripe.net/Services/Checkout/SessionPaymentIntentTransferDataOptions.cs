namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SessionPaymentIntentTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
