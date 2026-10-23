// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
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
        /// Unique identifier for the Form.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Data for appeal inquiries. Only present when type is appeal.
        /// </summary>
        [JsonProperty("appeal")]
        [STJS.JsonPropertyName("appeal")]
        public FormAppeal Appeal { get; set; }

        /// <summary>
        /// Data for authorization_documents inquiries. Only present when type is
        /// authorization_documents.
        /// </summary>
        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public FormAuthorizationDocuments AuthorizationDocuments { get; set; }

        /// <summary>
        /// Time at which the Form was closed.
        /// </summary>
        [JsonProperty("closed_at")]
        [STJS.JsonPropertyName("closed_at")]
        public DateTime ClosedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the Form was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which the Form was opened.
        /// </summary>
        [JsonProperty("opened_at")]
        [STJS.JsonPropertyName("opened_at")]
        public DateTime OpenedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Data for product_removal inquiries. Only present when type is product_removal.
        /// </summary>
        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public FormProductRemoval ProductRemoval { get; set; }

        /// <summary>
        /// Data for self_funding_context inquiries. Only present when type is self_funding_context.
        /// </summary>
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

        /// <summary>
        /// What this Form was raised about, as a typed object. Only present when the Form is scoped
        /// to a specific object. Absent when the Form covers the account as a whole.
        /// </summary>
        [JsonProperty("subject")]
        [STJS.JsonPropertyName("subject")]
        public FormSubject Subject { get; set; }

        /// <summary>
        /// Data for transaction_context inquiries. Only present when type is transaction_context.
        /// </summary>
        [JsonProperty("transaction_context")]
        [STJS.JsonPropertyName("transaction_context")]
        public FormTransactionContext TransactionContext { get; set; }

        /// <summary>
        /// The type of Form.
        /// One of: <c>appeal</c>, <c>authorization_documents</c>, <c>product_removal</c>,
        /// <c>self_funding_context</c>, or <c>transaction_context</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
