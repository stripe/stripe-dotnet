namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionSetupIntentDataOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }
    }
}
