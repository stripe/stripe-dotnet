// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderListOptions : ListOptions
    {
        /// <summary>
        /// Filters readers by device type.
        /// One of: <c>bbpos_chipper2x</c>, <c>bbpos_wisepad3</c>, <c>bbpos_wisepos_e</c>,
        /// <c>simulated_wisepos_e</c>, <c>stripe_m2</c>, or <c>verifone_P400</c>.
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// A location ID to filter the response list to only readers at the specific location.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Filters readers by serial number.
        /// </summary>
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// A status filter to filter readers to only offline or online readers.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
