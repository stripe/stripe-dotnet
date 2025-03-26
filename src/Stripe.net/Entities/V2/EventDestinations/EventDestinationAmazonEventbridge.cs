// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventDestinationAmazonEventbridge : StripeEntity<EventDestinationAmazonEventbridge>
    {
        /// <summary>
        /// The AWS account ID.
        /// </summary>
        [JsonProperty("aws_account_id")]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// The ARN of the AWS event source.
        /// </summary>
        [JsonProperty("aws_event_source_arn")]
        public string AwsEventSourceArn { get; set; }

        /// <summary>
        /// The state of the AWS event source.
        /// One of: <c>active</c>, <c>deleted</c>, <c>pending</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("aws_event_source_status")]
        public string AwsEventSourceStatus { get; set; }
    }
}
