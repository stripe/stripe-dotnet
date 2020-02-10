namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceCodeVerification : StripeEntity<SourceCodeVerification>
    {
        [JsonProperty("attempts_remaining")]
        public long AttemptsRemaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
