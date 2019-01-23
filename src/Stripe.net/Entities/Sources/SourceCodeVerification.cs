namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCodeVerification : StripeEntity<SourceCodeVerification>
    {
        /// <summary>
        /// The number of attempts remaining to authenticate the source object with a verification code.
        /// </summary>
        [JsonProperty("attempts_remaining")]
        public long AttemptsRemaining { get; set; }

        /// <summary>
        /// The status of the code verification, either pending, succeeded or failed.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
