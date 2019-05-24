namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class EarlyFraudWarningListOptions : ListOptions
    {
        /// <summary>
        /// Only return early fraud warnings for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
