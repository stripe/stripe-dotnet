// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataFeaturesBankAccountsWire : StripeEntity<AccountConfigurationRecipientDataFeaturesBankAccountsWire>
    {
        /// <summary>
        /// Whether or not the Feature has been requested.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool Requested { get; set; }

        /// <summary>
        /// Closed Enum. The current status of the Feature. Once the status is <c>active</c>, the
        /// Account is ready to be used in the product flow that the Feature represents.
        /// One of: <c>active</c>, <c>pending</c>, <c>restricted</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Additional details regarding the status of the Feature - will be empty if status is
        /// <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public List<AccountConfigurationRecipientDataFeaturesBankAccountsWireStatusDetail> StatusDetails { get; set; }
    }
}
