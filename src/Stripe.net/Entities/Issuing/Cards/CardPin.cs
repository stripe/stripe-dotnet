namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardPin : StripeEntity<CardPin>
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
