// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The endpoint configuration for the batch job.
        /// </summary>
        [JsonProperty("endpoint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("endpoint")]
#endif
        public BatchJobCreateEndpointOptions Endpoint { get; set; }

        /// <summary>
        /// Optional field that allows the user to control how fast they want this batch job to run.
        /// Gives them a control over the number of webhooks they receive.
        /// </summary>
        [JsonProperty("maximum_rps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_rps")]
#endif
        public long? MaximumRps { get; set; }

        /// <summary>
        /// The metadata of the <c>BatchJob</c> object.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Notification suppression settings for the batch job.
        /// </summary>
        [JsonProperty("notification_suppression")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("notification_suppression")]
#endif
        public BatchJobCreateNotificationSuppressionOptions NotificationSuppression { get; set; }

        /// <summary>
        /// Allows the user to skip validation.
        /// </summary>
        [JsonProperty("skip_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_validation")]
#endif
        public bool? SkipValidation { get; set; }
    }
}
