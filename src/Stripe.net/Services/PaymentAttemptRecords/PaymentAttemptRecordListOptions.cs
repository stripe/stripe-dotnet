// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordListOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Payment Record.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }
    }
}
