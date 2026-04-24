// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The product catalog import object tracks the long-running background process that
    /// handles uploading, processing and validation.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImport : StripeEntity<ProductCatalogImport>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The unique identifier for this ProductCatalogImport.
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
        /// The time this ProductCatalogImport was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The type of feed data being imported into the product catalog.
        /// One of: <c>inventory</c>, <c>pricing</c>, or <c>product</c>.
        /// </summary>
        [JsonProperty("feed_type")]
        [STJS.JsonPropertyName("feed_type")]
        public string FeedType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The current status of this ProductCatalogImport.
        /// One of: <c>awaiting_upload</c>, <c>failed</c>, <c>processing</c>, <c>succeeded</c>, or
        /// <c>succeeded_with_errors</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Details about the current import status.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ProductCatalogImportStatusDetails StatusDetails { get; set; }
    }
}
