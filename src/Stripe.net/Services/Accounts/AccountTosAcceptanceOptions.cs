namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountTosAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp marking when the account representative accepted the Stripe Services
        /// Agreement.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the account representative accepted the Stripe Services
        /// Agreement.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the account representative accepted the Stripe
        /// Services Agreement.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
