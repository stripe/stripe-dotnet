// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsEventDestinationOldConfigurationAmazonEventbridge : StripeEntity<ActivityLogDetailsEventDestinationOldConfigurationAmazonEventbridge>
    {
        /// <summary>
        /// AWS account ID configured for the event destination.
        /// </summary>
        [JsonProperty("aws_account_id")]
        [STJS.JsonPropertyName("aws_account_id")]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// ARN of the AWS event source configured for the event destination.
        /// </summary>
        [JsonProperty("aws_event_source_arn")]
        [STJS.JsonPropertyName("aws_event_source_arn")]
        public string AwsEventSourceArn { get; set; }

        /// <summary>
        /// AWS region configured for the event destination.
        /// </summary>
        [JsonProperty("aws_region")]
        [STJS.JsonPropertyName("aws_region")]
        public string AwsRegion { get; set; }
    }
}
