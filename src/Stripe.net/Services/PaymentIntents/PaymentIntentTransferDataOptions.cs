namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        // This is only available on creation and not update
        [JsonProperty("destination")]
        public string Destination { get; set; }

        [Obsolete("Use ApplicationFeeAmount on the parent options class instead.")]
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
