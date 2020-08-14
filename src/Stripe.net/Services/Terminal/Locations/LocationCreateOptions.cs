namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class LocationCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
