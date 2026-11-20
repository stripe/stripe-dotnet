// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderRefundPaymentConfigGiftCardOptions : INestedOptions
    {
        /// <summary>
        /// The brand of the destination gift card to collect on the reader.
        /// One of: <c>svs</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The gift card operation to perform with the refund amount.
        /// One of: <c>activation</c>, or <c>reload</c>.
        /// </summary>
        [JsonProperty("operation_type")]
        [STJS.JsonPropertyName("operation_type")]
        public string OperationType { get; set; }
    }
}
