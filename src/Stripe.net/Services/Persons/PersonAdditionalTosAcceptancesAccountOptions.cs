namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    [Obsolete("Use AccountPersonAdditionalTosAcceptancesAccountOptions instead.")]
    public class PersonAdditionalTosAcceptancesAccountOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp marking when the account representative accepted the service
        /// agreement.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

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
