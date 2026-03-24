// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesOutboundPaymentsCards : StripeEntity<AccountConfigurationStorerCapabilitiesOutboundPaymentsCards>
    {
        /// <summary>
        /// The status of the Capability.
        /// One of: <c>active</c>, <c>pending</c>, <c>restricted</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the capability's status. This value is empty when <c>status</c>
        /// is <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public List<AccountConfigurationStorerCapabilitiesOutboundPaymentsCardsStatusDetail> StatusDetails { get; set; }
    }
}
