namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EvidenceOptions : INestedOptions
    {
        [JsonProperty("fraudulent[dispute_explanation]")]
        public string FraudulentDisputeExplanation { get; set; }

        [JsonProperty("fraudulent[uncategorized_file]")]
        public string FraudulentUncategorizedFile { get; set; }

        [JsonProperty("other[dispute_explanation]")]
        public string OtherDisputeExplanation { get; set; }

        [JsonProperty("other[uncategorized_file]")]
        public string OtherUncategorizedFile { get; set; }
    }
}
