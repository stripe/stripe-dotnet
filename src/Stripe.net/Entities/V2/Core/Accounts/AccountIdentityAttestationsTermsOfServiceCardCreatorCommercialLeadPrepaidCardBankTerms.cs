// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCardBankTerms : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCardBankTerms>
    {
        /// <summary>
        /// The time when the Account's representative accepted the terms of service. Represented as
        /// a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date")]
#endif
        public DateTime? Date { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The IP address from which the Account's representative accepted the terms of service.
        /// </summary>
        [JsonProperty("ip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip")]
#endif
        public string Ip { get; set; }

        /// <summary>
        /// The URL to the service agreement the Account's representative accepted.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }

        /// <summary>
        /// The user agent of the browser from which the Account's representative accepted the terms
        /// of service.
        /// </summary>
        [JsonProperty("user_agent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_agent")]
#endif
        public string UserAgent { get; set; }
    }
}
