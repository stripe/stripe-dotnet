namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentSingleUseOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
