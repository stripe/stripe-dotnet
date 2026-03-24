// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventDestinationCreateAmazonEventbridgeOptions : INestedOptions
    {
        /// <summary>
        /// The AWS account ID.
        /// </summary>
        [JsonProperty("aws_account_id")]
        [STJS.JsonPropertyName("aws_account_id")]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// The region of the AWS event source.
        /// </summary>
        [JsonProperty("aws_region")]
        [STJS.JsonPropertyName("aws_region")]
        public string AwsRegion { get; set; }
    }
}
