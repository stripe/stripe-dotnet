// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataFeaturesCardsStatusDetail : StripeEntity<AccountConfigurationRecipientDataFeaturesCardsStatusDetail>
    {
        /// <summary>
        /// Closed Enum. Status code, explaining why the Feature has a given status, if it is not
        /// <c>active</c>.
        /// One of: <c>determining_status</c>, <c>requirements_past_due</c>,
        /// <c>requirements_pending_verification</c>, <c>restricted_other</c>, or
        /// <c>unsupported_country</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// Closed Enum. Additional information about how to resolve the Feature status, if it is
        /// not <c>active</c>.
        /// One of: <c>contact_stripe</c>, <c>no_resolution</c>, or <c>provide_info</c>.
        /// </summary>
        [JsonProperty("resolution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resolution")]
#endif
        public string Resolution { get; set; }
    }
}
