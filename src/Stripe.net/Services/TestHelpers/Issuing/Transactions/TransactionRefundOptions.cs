// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class TransactionRefundOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to refund. This amount is in the provided currency, or
        /// defaults to the cards currency, and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("refund_amount")]
        public long? RefundAmount { get; set; }
    }
}
