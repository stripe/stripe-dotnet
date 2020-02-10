namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandateSingleUse : StripeEntity<MandateSingleUse>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
