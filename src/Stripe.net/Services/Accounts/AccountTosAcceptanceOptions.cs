// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTosAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp marking when the account representative accepted their service
        /// agreement.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the account representative accepted their service agreement.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user's service agreement type.
        /// </summary>
        [JsonProperty("service_agreement")]
        [STJS.JsonPropertyName("service_agreement")]
        public string ServiceAgreement { get; set; }

        /// <summary>
        /// The user agent of the browser from which the account representative accepted their
        /// service agreement.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
