namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountTosAcceptance : StripeEntity<AccountTosAcceptance>
    {
        /// <summary>
        /// The Unix timestamp marking when the Stripe Services Agreement was accepted by the
        /// account representative.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the Stripe Services Agreement was accepted by the account
        /// representative.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the Stripe Services Agreement was accepted by
        /// the account representative.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
