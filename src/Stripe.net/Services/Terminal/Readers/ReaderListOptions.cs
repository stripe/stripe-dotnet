// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderListOptions : ListOptions
    {
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
