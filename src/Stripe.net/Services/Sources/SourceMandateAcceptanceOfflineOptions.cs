namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }
}
