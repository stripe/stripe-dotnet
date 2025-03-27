// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentListOptions : ListOptions
    {
        /// <summary>
        /// The identifier of the invoice whose payments to return.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        /// <summary>
        /// The payment details of the invoice payments to return.
        /// </summary>
        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public InvoicePaymentPaymentOptions Payment { get; set; }

        /// <summary>
        /// The status of the invoice payments to return.
        /// One of: <c>canceled</c>, <c>open</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
