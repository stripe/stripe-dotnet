namespace Stripe
{
    using Newtonsoft.Json;

    public class AddressJapan : Address
    {
        [JsonProperty("town")]
        public string Town { get; set; }
    }
}
