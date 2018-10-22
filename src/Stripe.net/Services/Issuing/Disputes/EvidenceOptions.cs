namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EvidenceOptions : INestedOptions
    {
        [JsonProperty("fraudulent")]
        public EvidenceDetailsOptions Fraudulent { get; set; }

        [JsonProperty("other")]
        public EvidenceDetailsOptions Other { get; set; }
    }
}
