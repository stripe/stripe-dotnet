namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EvidenceOptions : INestedOptions
    {
        [JsonProperty("fraudulent")]
        public EvidenceDetailsOptions Fraudulent { get; set; }

        [JsonProperty("other")]
        public EvidenceDetailsOptions Other { get; set; }
    }
}
