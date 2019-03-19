namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodAttachOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
