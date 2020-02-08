namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeDestinationOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
