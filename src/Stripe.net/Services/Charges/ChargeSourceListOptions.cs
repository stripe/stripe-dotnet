namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeSourceListOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
