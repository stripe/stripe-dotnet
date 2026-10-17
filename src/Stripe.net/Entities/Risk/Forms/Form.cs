// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A risk Form represents a request from Stripe for information about a connected account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Form : StripeEntity<Form>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("appeal")]
        [STJS.JsonPropertyName("appeal")]
        public FormAppeal Appeal { get; set; }

        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public FormAuthorizationDocuments AuthorizationDocuments { get; set; }

        /// <summary>
        /// Time at which the Form closed, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("closed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("closed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If it exists in a sandbox,
        /// the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which the Form opened, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("opened_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("opened_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? OpenedAt { get; set; }

        [JsonProperty("payment_processing")]
        [STJS.JsonPropertyName("payment_processing")]
        public FormPaymentProcessing PaymentProcessing { get; set; }

        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public FormProductRemoval ProductRemoval { get; set; }

        [JsonProperty("reviewed_fields")]
        [STJS.JsonPropertyName("reviewed_fields")]
        public FormReviewedFields ReviewedFields { get; set; }

        [JsonProperty("self_funding_context")]
        [STJS.JsonPropertyName("self_funding_context")]
        public FormSelfFundingContext SelfFundingContext { get; set; }

        /// <summary>
        /// The current status of the Form.
        /// One of: <c>closed</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        [STJS.JsonPropertyName("subject")]
        public FormSubject Subject { get; set; }

        [JsonProperty("transaction_context")]
        [STJS.JsonPropertyName("transaction_context")]
        public FormTransactionContext TransactionContext { get; set; }

        /// <summary>
        /// The type of information requested by Stripe.
        /// One of: <c>appeal</c>, <c>authorization_documents</c>, <c>payment_processing</c>,
        /// <c>product_removal</c>, <c>reviewed_fields</c>, <c>self_funding_context</c>, or
        /// <c>transaction_context</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
