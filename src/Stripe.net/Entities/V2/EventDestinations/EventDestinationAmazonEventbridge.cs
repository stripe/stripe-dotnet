// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationAmazonEventbridge : StripeEntity<EventDestinationAmazonEventbridge>
    {
        /// <summary>
        /// The AWS account ID.
        /// </summary>
        [JsonProperty("aws_account_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aws_account_id")]
#endif
        public string AwsAccountId { get; set; }

        /// <summary>
        /// The ARN of the AWS event source.
        /// </summary>
        [JsonProperty("aws_event_source_arn")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aws_event_source_arn")]
#endif
        public string AwsEventSourceArn { get; set; }

        /// <summary>
        /// The state of the AWS event source.
        /// One of: <c>active</c>, <c>deleted</c>, <c>pending</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("aws_event_source_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aws_event_source_status")]
#endif
        public string AwsEventSourceStatus { get; set; }
    }
}
