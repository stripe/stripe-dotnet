namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeCreateOptions : CardholderSharedOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("evidence")]
        public EvidenceOptions Evidence { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("transaction")]
        public string TransactionId { get; set; }
    }
}
