// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentListOptions : ListOptions
    {
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public InvoicePaymentPaymentOptions Payment { get; set; }

        /// <summary>
        /// One of: <c>canceled</c>, <c>open</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
