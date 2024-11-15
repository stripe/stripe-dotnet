// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionRefundOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to refund. This amount is in the provided currency, or
        /// defaults to the cards currency, and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("refund_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_amount")]
#endif

        public long? RefundAmount { get; set; }
    }
}
