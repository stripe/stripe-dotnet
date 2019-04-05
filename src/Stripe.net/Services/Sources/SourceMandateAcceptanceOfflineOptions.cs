namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }
}
