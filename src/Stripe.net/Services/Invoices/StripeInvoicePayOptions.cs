namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeInvoicePayOptions : StripeBaseOptions
    {
        [JsonProperty("forgive")]
        public bool? Forgive { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }
    }
}
