// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Provide this for Forms of type <c>appeal</c>.
        /// </summary>
        [JsonProperty("appeal")]
        [STJS.JsonPropertyName("appeal")]
        public FormAppealOptions Appeal { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>authorization_documents</c>.
        /// </summary>
        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public FormAuthorizationDocumentsOptions AuthorizationDocuments { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>payment_processing</c>.
        /// </summary>
        [JsonProperty("payment_processing")]
        [STJS.JsonPropertyName("payment_processing")]
        public FormPaymentProcessingOptions PaymentProcessing { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>product_removal</c>.
        /// </summary>
        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public FormProductRemovalOptions ProductRemoval { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>reviewed_fields</c>.
        /// </summary>
        [JsonProperty("reviewed_fields")]
        [STJS.JsonPropertyName("reviewed_fields")]
        public FormReviewedFieldsOptions ReviewedFields { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>self_funding_context</c>.
        /// </summary>
        [JsonProperty("self_funding_context")]
        [STJS.JsonPropertyName("self_funding_context")]
        public FormSelfFundingContextOptions SelfFundingContext { get; set; }

        /// <summary>
        /// Provide this for Forms of type <c>transaction_context</c>.
        /// </summary>
        [JsonProperty("transaction_context")]
        [STJS.JsonPropertyName("transaction_context")]
        public FormTransactionContextOptions TransactionContext { get; set; }
    }
}
