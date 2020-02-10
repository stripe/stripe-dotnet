namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EvidenceDetailsOptions : INestedOptions
    {
        [JsonProperty("dispute_explanation")]
        public string DisputeExplanation { get; set; }

        [JsonProperty("uncategorized_file")]
        public string UncategorizedFile { get; set; }
    }
}
