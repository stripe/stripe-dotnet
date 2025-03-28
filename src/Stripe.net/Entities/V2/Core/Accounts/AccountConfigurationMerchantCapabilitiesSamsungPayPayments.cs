// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantCapabilitiesSamsungPayPayments : StripeEntity<AccountConfigurationMerchantCapabilitiesSamsungPayPayments>
    {
        /// <summary>
        /// Whether the Capability has been requested.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool Requested { get; set; }

        /// <summary>
        /// The status of the Capability.
        /// One of: <c>active</c>, <c>pending</c>, <c>restricted</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Additional details regarding the status of the Capability. <c>status_details</c> will be
        /// empty if the Capability's status is <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public List<AccountConfigurationMerchantCapabilitiesSamsungPayPaymentsStatusDetail> StatusDetails { get; set; }
    }
}
