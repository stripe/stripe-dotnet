namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderReturnOptions : BaseOptions
    {
        /// <summary>
        /// List of items to return.
        /// </summary>
        [JsonProperty("items")]
        public List<OrderReturnItemOptions> Items { get; set; }
    }
}
