// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantCapabilitiesEpsPaymentsStatusDetail : StripeEntity<AccountConfigurationMerchantCapabilitiesEpsPaymentsStatusDetail>
    {
        /// <summary>
        /// Machine-readable code explaining the reason for the Capability to be in its current
        /// status.
        /// One of: <c>determining_status</c>, <c>requirements_past_due</c>,
        /// <c>requirements_pending_verification</c>, <c>restricted_other</c>,
        /// <c>unsupported_business</c>, or <c>unsupported_country</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// Machine-readable code explaining how to make the Capability active.
        /// One of: <c>contact_stripe</c>, <c>no_resolution</c>, or <c>provide_info</c>.
        /// </summary>
        [JsonProperty("resolution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resolution")]
#endif
        public string Resolution { get; set; }
    }
}
