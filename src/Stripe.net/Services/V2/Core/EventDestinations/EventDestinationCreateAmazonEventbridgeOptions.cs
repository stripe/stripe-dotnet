// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationCreateAmazonEventbridgeOptions : INestedOptions
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
        /// The region of the AWS event source.
        /// </summary>
        [JsonProperty("aws_region")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aws_region")]
#endif
        public string AwsRegion { get; set; }
    }
}
