namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderReturnListOptions : ListOptionsWithCreated
    {
        [JsonProperty("order")]
        public string Order { get; set; }
    }
}
