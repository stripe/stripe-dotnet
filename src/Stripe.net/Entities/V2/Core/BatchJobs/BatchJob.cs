// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// BatchJob resource.
    /// </summary>
    public class BatchJob : StripeEntity<BatchJob>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the BatchJob.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Timestamp at which BatchJob was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The maximum rps defined for the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("maximum_rps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_rps")]
#endif
        public long MaximumRps { get; set; }

        /// <summary>
        /// The metadata of the <c>BatchJob</c> object.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If the validation will be run previous to the execution of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("skip_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_validation")]
#endif
        public bool SkipValidation { get; set; }

        /// <summary>
        /// The current status of the <c>BatchJob</c>.
        /// One of: <c>batch_failed</c>, <c>canceled</c>, <c>cancelling</c>, <c>complete</c>,
        /// <c>in_progress</c>, <c>ready_for_upload</c>, <c>timeout</c>, <c>upload_timeout</c>,
        /// <c>validating</c>, or <c>validation_failed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public BatchJobStatusDetails StatusDetails { get; set; }
    }
}
