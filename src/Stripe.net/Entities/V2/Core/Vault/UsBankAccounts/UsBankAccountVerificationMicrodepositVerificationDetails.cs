// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class UsBankAccountVerificationMicrodepositVerificationDetails : StripeEntity<UsBankAccountVerificationMicrodepositVerificationDetails>
    {
        /// <summary>
        /// Time when microdeposits will expire and have to be re-sent.
        /// </summary>
        [JsonProperty("expires")]
        [STJS.JsonPropertyName("expires")]
        public DateTime Expires { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Microdeposit type can be amounts or descriptor_type.
        /// One of: <c>amounts</c>, or <c>descriptor_code</c>.
        /// </summary>
        [JsonProperty("microdeposit_type")]
        [STJS.JsonPropertyName("microdeposit_type")]
        public string MicrodepositType { get; set; }

        /// <summary>
        /// Time when microdeposits were sent.
        /// </summary>
        [JsonProperty("sent")]
        [STJS.JsonPropertyName("sent")]
        public DateTime Sent { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
