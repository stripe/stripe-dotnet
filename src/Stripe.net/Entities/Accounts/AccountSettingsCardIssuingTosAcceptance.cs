// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardIssuingTosAcceptance : StripeEntity<AccountSettingsCardIssuingTosAcceptance>
    {
        /// <summary>
        /// The Unix timestamp marking when the account representative accepted the service
        /// agreement.
        /// </summary>
        [JsonProperty("date")]
        public long? Date { get; set; }

        /// <summary>
        /// The IP address from which the account representative accepted the service agreement.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the account representative accepted the service
        /// agreement.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
