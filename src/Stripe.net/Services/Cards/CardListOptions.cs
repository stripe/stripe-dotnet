namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "card";
    }
}
