namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceFinalizeOptions : BaseOptions
    {
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
