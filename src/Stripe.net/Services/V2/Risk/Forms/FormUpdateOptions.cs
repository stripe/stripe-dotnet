// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Provide this for appeal inquiries.
        /// </summary>
        [JsonProperty("appeal")]
        [STJS.JsonPropertyName("appeal")]
        public FormUpdateAppealOptions Appeal { get; set; }

        /// <summary>
        /// Provide this for authorization_documents inquiries.
        /// </summary>
        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public FormUpdateAuthorizationDocumentsOptions AuthorizationDocuments { get; set; }

        /// <summary>
        /// Provide this for product_removal inquiries.
        /// </summary>
        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public FormUpdateProductRemovalOptions ProductRemoval { get; set; }

        /// <summary>
        /// Provide this for self_funding_context inquiries.
        /// </summary>
        [JsonProperty("self_funding_context")]
        [STJS.JsonPropertyName("self_funding_context")]
        public FormUpdateSelfFundingContextOptions SelfFundingContext { get; set; }

        /// <summary>
        /// Provide this for transaction_context inquiries.
        /// </summary>
        [JsonProperty("transaction_context")]
        [STJS.JsonPropertyName("transaction_context")]
        public FormUpdateTransactionContextOptions TransactionContext { get; set; }
    }
}
