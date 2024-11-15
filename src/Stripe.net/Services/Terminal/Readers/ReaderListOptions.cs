// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderListOptions : ListOptions
    {
        /// <summary>
        /// Filters readers by device type.
        /// One of: <c>bbpos_chipper2x</c>, <c>bbpos_wisepad3</c>, <c>bbpos_wisepos_e</c>,
        /// <c>mobile_phone_reader</c>, <c>simulated_wisepos_e</c>, <c>stripe_m2</c>,
        /// <c>stripe_s700</c>, or <c>verifone_P400</c>.
        /// </summary>
        [JsonProperty("device_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_type")]
#endif

        public string DeviceType { get; set; }

        /// <summary>
        /// A location ID to filter the response list to only readers at the specific location.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif

        public string Location { get; set; }

        /// <summary>
        /// Filters readers by serial number.
        /// </summary>
        [JsonProperty("serial_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("serial_number")]
#endif

        public string SerialNumber { get; set; }

        /// <summary>
        /// A status filter to filter readers to only offline or online readers.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
