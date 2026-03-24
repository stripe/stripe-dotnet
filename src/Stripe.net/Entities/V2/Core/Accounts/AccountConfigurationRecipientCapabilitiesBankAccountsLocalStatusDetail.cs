// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilitiesBankAccountsLocalStatusDetail : StripeEntity<AccountConfigurationRecipientCapabilitiesBankAccountsLocalStatusDetail>
    {
        /// <summary>
        /// Machine-readable code explaining the reason for the Capability to be in its current
        /// status.
        /// One of: <c>determining_status</c>, <c>requirements_past_due</c>,
        /// <c>requirements_pending_verification</c>, <c>restricted_other</c>,
        /// <c>unsupported_business</c>, <c>unsupported_country</c>, or
        /// <c>unsupported_entity_type</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Machine-readable code explaining how to make the Capability active.
        /// One of: <c>contact_stripe</c>, <c>no_resolution</c>, or <c>provide_info</c>.
        /// </summary>
        [JsonProperty("resolution")]
        [STJS.JsonPropertyName("resolution")]
        public string Resolution { get; set; }
    }
}
