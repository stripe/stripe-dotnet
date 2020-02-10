namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EarlyFraudWarningListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
