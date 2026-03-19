// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardFinancingDisclosuresOptions : INestedOptions
    {
        /// <summary>
        /// The time when the Account's representative accepted the terms of service. Represented as
        /// a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("date")]
        [STJS.JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the Account's representative accepted the terms of service.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the Account's representative accepted the terms
        /// of service.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
