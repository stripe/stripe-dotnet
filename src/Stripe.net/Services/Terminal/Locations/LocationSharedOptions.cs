namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class LocationSharedOptions : BaseOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [Obsolete("This feature has been deprecated and should not be used moving forward.")]
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
