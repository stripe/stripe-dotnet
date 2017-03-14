using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCodeVerification : StripeEntity
    {
        /// <summary>
        /// The number of attempts remaining to authenticate the source object with a verification code.
        /// </summary>
        [JsonProperty("attempts_remaining")]
        public int AttemptsRemaining { get; set; }

        /// <summary>
        /// The status of the code verification, either pending, succeeded or failed.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
