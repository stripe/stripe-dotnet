namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("pending")]
        public bool? Pending { get; set; }
    }
}
