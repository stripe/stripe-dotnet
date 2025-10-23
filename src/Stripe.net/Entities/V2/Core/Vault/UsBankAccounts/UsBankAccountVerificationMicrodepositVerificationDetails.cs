// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountVerificationMicrodepositVerificationDetails : StripeEntity<UsBankAccountVerificationMicrodepositVerificationDetails>
    {
        /// <summary>
        /// Time when microdeposits will expire and have to be re-sent.
        /// </summary>
        [JsonProperty("expires")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires")]
#endif
        public DateTime Expires { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Microdeposit type can be amounts or descriptor_type.
        /// One of: <c>amounts</c>, or <c>descriptor_code</c>.
        /// </summary>
        [JsonProperty("microdeposit_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("microdeposit_type")]
#endif
        public string MicrodepositType { get; set; }

        /// <summary>
        /// Time when microdeposits were sent.
        /// </summary>
        [JsonProperty("sent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sent")]
#endif
        public DateTime Sent { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
