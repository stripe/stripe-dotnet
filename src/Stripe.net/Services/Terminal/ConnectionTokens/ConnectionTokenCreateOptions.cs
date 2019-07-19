namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        [JsonProperty("location")]
        public string LocationId { get; set; }
    }
}
