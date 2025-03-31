// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when the invoice is paid. If no amount
        /// is set, the full amount is transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif
        public string Destination { get; set; }
    }
}
