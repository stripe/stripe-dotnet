// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkListOptions : ListOptions
    {
        /// <summary>
        /// Only return payment links that are active or inactive (e.g., pass <c>false</c> to list
        /// all inactive payment links).
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif

        public bool? Active { get; set; }
    }
}
