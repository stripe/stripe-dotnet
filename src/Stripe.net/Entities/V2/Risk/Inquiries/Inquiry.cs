// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A risk inquiry represents a request from Stripe for information about a connected
    /// account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Inquiry : StripeEntity<Inquiry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the inquiry.
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
        public InquiryAppeal Appeal { get; set; }

        /// <summary>
        /// Data for authorization_documents inquiries. Only present when type is
        /// authorization_documents.
        /// </summary>
        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public InquiryAuthorizationDocuments AuthorizationDocuments { get; set; }

        /// <summary>
        /// Time at which the inquiry was closed.
        /// </summary>
        [JsonProperty("closed_at")]
        [STJS.JsonPropertyName("closed_at")]
        public DateTime ClosedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the inquiry was created.
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
        /// Time at which the inquiry was opened.
        /// </summary>
        [JsonProperty("opened_at")]
        [STJS.JsonPropertyName("opened_at")]
        public DateTime OpenedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Data for product_removal inquiries. Only present when type is product_removal.
        /// </summary>
        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public InquiryProductRemoval ProductRemoval { get; set; }

        /// <summary>
        /// The current status of the inquiry.
        /// One of: <c>closed</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of inquiry.
        /// One of: <c>appeal</c>, <c>authorization_documents</c>, or <c>product_removal</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
