// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonAdditionalTosAcceptancesAccount : StripeEntity<PersonAdditionalTosAcceptancesAccount>
    {
        /// <summary>
        /// The Unix timestamp marking when the legal guardian accepted the service agreement.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the legal guardian accepted the service agreement.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the legal guardian accepted the service
        /// agreement.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
