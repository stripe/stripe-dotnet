// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantCapabilitiesPaynowPayments : StripeEntity<AccountConfigurationMerchantCapabilitiesPaynowPayments>
    {
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
        /// Additional details about the capability's status. This value is empty when <c>status</c>
        /// is <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public List<AccountConfigurationMerchantCapabilitiesPaynowPaymentsStatusDetail> StatusDetails { get; set; }
    }
}
