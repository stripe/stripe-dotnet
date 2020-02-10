namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeDestinationCreateOptions : ChargeDestinationOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
