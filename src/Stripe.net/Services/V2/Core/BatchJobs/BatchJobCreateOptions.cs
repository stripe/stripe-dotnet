// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BatchJobCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The endpoint configuration for the batch job.
        /// </summary>
        [JsonProperty("endpoint")]
        [STJS.JsonPropertyName("endpoint")]
        public BatchJobCreateEndpointOptions Endpoint { get; set; }

        /// <summary>
        /// Optional field that allows the user to control how fast they want this batch job to run.
        /// Gives them a control over the number of webhooks they receive.
        /// </summary>
        [JsonProperty("maximum_rps")]
        [STJS.JsonPropertyName("maximum_rps")]
        public long? MaximumRps { get; set; }

        /// <summary>
        /// The metadata of the <c>BatchJob</c> object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Notification suppression settings for the batch job.
        /// </summary>
        [JsonProperty("notification_suppression")]
        [STJS.JsonPropertyName("notification_suppression")]
        public BatchJobCreateNotificationSuppressionOptions NotificationSuppression { get; set; }

        /// <summary>
        /// Allows the user to skip validation.
        /// </summary>
        [JsonProperty("skip_validation")]
        [STJS.JsonPropertyName("skip_validation")]
        public bool? SkipValidation { get; set; }
    }
}
