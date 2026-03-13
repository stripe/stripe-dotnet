// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordProcessorDetailsCustomOptions : INestedOptions
    {
        /// <summary>
        /// A reference to the external refund. This field must be unique across all refunds.
        /// </summary>
        [JsonProperty("refund_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_reference")]
#endif
        public string RefundReference { get; set; }
    }
}
