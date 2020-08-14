namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountBusinessProfileOptions : INestedOptions
    {
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("support_address")]
        public AddressOptions SupportAddress { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
