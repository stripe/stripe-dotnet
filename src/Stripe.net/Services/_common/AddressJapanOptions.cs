namespace Stripe
{
    using Newtonsoft.Json;

    public class AddressJapanOptions : AddressOptions
    {
        [JsonProperty("town")]
        public string Town { get; set; }
    }
}
