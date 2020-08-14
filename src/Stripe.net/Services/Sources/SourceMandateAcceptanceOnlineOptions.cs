namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOnlineOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp (in seconds) when the mandate was accepted or refused by the
        /// customer.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the mandate was accepted or refused by the customer.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the mandate was accepted or refused by the
        /// customer.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
