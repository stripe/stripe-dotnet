namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderCreateOptions : CardholderSharedOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
