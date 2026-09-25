// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventDestinationAmazonEventbridge : StripeEntity<EventDestinationAmazonEventbridge>
    {
        /// <summary>
        /// The AWS account ID that owns the event bus receiving events.
        /// </summary>
        [JsonProperty("aws_account_id")]
        [STJS.JsonPropertyName("aws_account_id")]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// The ARN of the Stripe-created partner event source in your AWS account.
        /// </summary>
        [JsonProperty("aws_event_source_arn")]
        [STJS.JsonPropertyName("aws_event_source_arn")]
        public string AwsEventSourceArn { get; set; }

        /// <summary>
        /// The AWS-reported lifecycle state of the partner event source.
        /// One of: <c>active</c>, <c>deleted</c>, <c>pending</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("aws_event_source_status")]
        [STJS.JsonPropertyName("aws_event_source_status")]
        public string AwsEventSourceStatus { get; set; }
    }
}
