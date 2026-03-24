// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceCodeVerification : StripeEntity<SourceCodeVerification>
    {
        /// <summary>
        /// The number of attempts remaining to authenticate the source object with a verification
        /// code.
        /// </summary>
        [JsonProperty("attempts_remaining")]
        [STJS.JsonPropertyName("attempts_remaining")]
        public long AttemptsRemaining { get; set; }

        /// <summary>
        /// The status of the code verification, either <c>pending</c> (awaiting verification,
        /// <c>attempts_remaining</c> should be greater than 0), <c>succeeded</c> (successful
        /// verification) or <c>failed</c> (failed verification, cannot be verified anymore as
        /// <c>attempts_remaining</c> should be 0).
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
