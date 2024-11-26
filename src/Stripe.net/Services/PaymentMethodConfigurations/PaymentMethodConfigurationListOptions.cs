// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// The Connect application to filter by.
        /// </summary>
        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
#endif
        public string Application { get; set; }
    }
}
