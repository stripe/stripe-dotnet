namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EvidenceDetailsOptions : INestedOptions
    {
        [JsonProperty("dispute_explanation")]
        public string DisputeExplanation { get; set; }

        [JsonProperty("uncategorized_file")]
        public string UncategorizedFile { get; set; }
    }
}
