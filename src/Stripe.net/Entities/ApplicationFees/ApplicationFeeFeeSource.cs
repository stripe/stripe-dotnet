// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeFeeSource : StripeEntity<ApplicationFeeFeeSource>
    {
        /// <summary>
        /// Charge ID that created this application fee.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Payout ID that created this application fee.
        /// </summary>
        [JsonProperty("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// Type of object that created the application fee, either <c>charge</c> or <c>payout</c>.
        /// One of: <c>charge</c>, or <c>payout</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
