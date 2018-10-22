namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateOptions : INestedOptions
    {
        [JsonProperty("acceptance")]
        public SourceMandateAcceptanceOptions Acceptance { get; set; }
    }
}
