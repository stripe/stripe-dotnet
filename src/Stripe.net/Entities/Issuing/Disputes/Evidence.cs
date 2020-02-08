namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Evidence : StripeEntity<Evidence>
    {
        [JsonProperty("fraudulent")]
        public EvidenceFraudulent Fraudulent { get; set; }

        [JsonProperty("other")]
        public EvidenceOther Other { get; set; }
    }
}
