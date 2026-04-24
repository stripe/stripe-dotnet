// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A batch job allows you to perform an API operation on a large set of records
    /// asynchronously.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJob : StripeEntity<BatchJob>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the <c>batch_job</c>.
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
        /// Timestamp at which the <c>batch_job</c> was created.
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
        /// The maximum requests per second defined for the <c>batch_job</c>.
        /// </summary>
        [JsonProperty("maximum_rps")]
        [STJS.JsonPropertyName("maximum_rps")]
        public long MaximumRps { get; set; }

        /// <summary>
        /// The metadata of the <c>batch_job</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether validation runs before executing the <c>batch_job</c>.
        /// </summary>
        [JsonProperty("skip_validation")]
        [STJS.JsonPropertyName("skip_validation")]
        public bool SkipValidation { get; set; }

        /// <summary>
        /// The current status of the <c>batch_job</c>.
        /// One of: <c>batch_failed</c>, <c>canceled</c>, <c>cancelling</c>, <c>complete</c>,
        /// <c>in_progress</c>, <c>ready_for_upload</c>, <c>timeout</c>, <c>upload_timeout</c>,
        /// <c>validating</c>, or <c>validation_failed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>batch_job</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public BatchJobStatusDetails StatusDetails { get; set; }
    }
}
