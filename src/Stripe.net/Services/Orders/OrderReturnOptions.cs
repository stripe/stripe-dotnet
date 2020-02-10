namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderReturnOptions : BaseOptions
    {
        [JsonProperty("items")]
        public List<OrderReturnItemOptions> Items { get; set; }
    }
}
