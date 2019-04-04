namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateOfflineOptions : INestedOptions
    {
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }
}
