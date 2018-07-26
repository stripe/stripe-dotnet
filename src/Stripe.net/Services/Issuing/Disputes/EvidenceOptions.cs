namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EvidenceOptions : INestedOptions
    {
        [JsonProperty("evidence[fraudulent][dispute_explanation]")]
        public string FraudulentDisputeExplanation { get; set; }

        [JsonProperty("evidence[fraudulent][uncategorized_file]")]
        public string FraudulentUncategorizedFile { get; set; }

        [JsonProperty("evidence[other][dispute_explanation]")]
        public string OtherDisputeExplanation { get; set; }

        [JsonProperty("evidence[other][uncategorized_file]")]
        public string OtherUncategorizedFile { get; set; }
    }
}
