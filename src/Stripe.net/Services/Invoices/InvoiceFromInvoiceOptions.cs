// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceFromInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The relation between the new invoice and the original invoice. Currently, only
        /// 'revision' is permitted.
        /// </summary>
        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif
        public string Action { get; set; }

        /// <summary>
        /// The <c>id</c> of the invoice that will be cloned.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }
    }
}
