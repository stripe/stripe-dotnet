namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderReturnOptions : BaseOptions
    {
        [JsonProperty("items")]
        public List<OrderReturnItemOptions> Items { get; set; }
    }
}
