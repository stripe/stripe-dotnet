namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PlanTransformUsage : StripeEntity<PlanTransformUsage>
    {
        [JsonProperty("divide_by")]
        public long DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
