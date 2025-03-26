// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionVerifyWithMicrodeposits : StripeEntity<PaymentIntentNextActionVerifyWithMicrodeposits>
    {
        /// <summary>
        /// The timestamp when the microdeposits are expected to land.
        /// </summary>
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the hosted verification page, which allows customers to verify their bank
        /// account.
        /// </summary>
        [JsonProperty("hosted_verification_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_verification_url")]
#endif
        public string HostedVerificationUrl { get; set; }

        /// <summary>
        /// The type of the microdeposit sent to the customer. Used to distinguish between different
        /// verification methods.
        /// One of: <c>amounts</c>, or <c>descriptor_code</c>.
        /// </summary>
        [JsonProperty("microdeposit_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("microdeposit_type")]
#endif
        public string MicrodepositType { get; set; }
    }
}
