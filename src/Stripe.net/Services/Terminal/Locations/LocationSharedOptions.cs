namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class LocationSharedOptions : BaseOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
