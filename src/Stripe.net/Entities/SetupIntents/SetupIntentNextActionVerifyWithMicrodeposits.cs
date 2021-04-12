// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentNextActionVerifyWithMicrodeposits : StripeEntity<SetupIntentNextActionVerifyWithMicrodeposits>
    {
        /// <summary>
        /// The timestamp when the microdeposits are expected to land.
        /// </summary>
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the hosted verification page, which allows customers to verify their bank
        /// account.
        /// </summary>
        [JsonProperty("hosted_verification_url")]
        public string HostedVerificationUrl { get; set; }
    }
}
