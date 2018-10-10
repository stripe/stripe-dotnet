namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeCreateOptions : CardholderSharedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("disputed_transaction")]
        public string DisputedTransactionId { get; set; }

        [JsonProperty("evidence")]
        public EvidenceOptions Evidence { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
