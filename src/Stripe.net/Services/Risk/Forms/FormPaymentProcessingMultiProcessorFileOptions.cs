// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormPaymentProcessingMultiProcessorFileOptions : INestedOptions
    {
        /// <summary>
        /// ID of the uploaded file. Upload using /v1/files before referencing it here.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// What kind of document this is. One of alt_financial_statements, recent_bank_statements,
        /// or payment_receipt.
        /// </summary>
        [JsonProperty("tag")]
        [STJS.JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
