// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormPaymentProcessingMultiProcessorFile : StripeEntity<FormPaymentProcessingMultiProcessorFile>
    {
        /// <summary>
        /// ID of the uploaded file.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// The document type: <c>alt_financial_statements</c>, <c>recent_bank_statements</c>, or
        /// <c>payment_receipt</c>.
        /// </summary>
        [JsonProperty("tag")]
        [STJS.JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
