// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce.ProductCatalog
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ImportListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for objects created at the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Filter for objects created after the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_gt")]
        [STJS.JsonPropertyName("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for objects created on or after the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_gte")]
        [STJS.JsonPropertyName("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for objects created before the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_lt")]
        [STJS.JsonPropertyName("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for objects created on or before the specified timestamp. Must be an RFC 3339
        /// date &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_lte")]
        [STJS.JsonPropertyName("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter by the type of feed data being imported.
        /// One of: <c>inventory</c>, <c>pricing</c>, or <c>product</c>.
        /// </summary>
        [JsonProperty("feed_type")]
        [STJS.JsonPropertyName("feed_type")]
        public string FeedType { get; set; }

        /// <summary>
        /// Filter by import status.
        /// One of: <c>awaiting_upload</c>, <c>failed</c>, <c>processing</c>, <c>succeeded</c>, or
        /// <c>succeeded_with_errors</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
