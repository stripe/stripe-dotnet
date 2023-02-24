// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualCardIssuingUserTermsAcceptance : StripeEntity<CardholderIndividualCardIssuingUserTermsAcceptance>
    {
        /// <summary>
        /// The Unix timestamp marking when the cardholder accepted the Authorized User Terms.
        /// Required for Celtic Spend Card users.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the cardholder accepted the Authorized User Terms. Required
        /// for Celtic Spend Card users.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the cardholder accepted the Authorized User
        /// Terms.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
