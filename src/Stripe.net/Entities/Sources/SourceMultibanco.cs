namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
