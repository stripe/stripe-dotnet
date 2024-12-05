// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeEvidenceOtherOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Description of the merchandise or service that was purchased.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Whether the product was a merchandise or service.
        /// One of: <c>merchandise</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }
    }
}
