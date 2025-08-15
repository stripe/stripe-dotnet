// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientData : StripeEntity<AccountConfigurationRecipientData>
    {
        /// <summary>
        /// The payout method id to be used as a default outbound destination. This will allow the
        /// PayoutMethod to be omitted on OutboundPayments made through API or sending payouts via
        /// dashboard.
        /// </summary>
        [JsonProperty("default_outbound_destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_outbound_destination")]
#endif
        public AccountConfigurationRecipientDataDefaultOutboundDestination DefaultOutboundDestination { get; set; }

        /// <summary>
        /// Features representing the functionality that should be enabled for when this Account is
        /// used as a recipient. Features need to be explicitly requested, and the <c>status</c>
        /// field indicates if the Feature is <c>active</c>, <c>restricted</c> or <c>pending</c>.
        /// Once a Feature is <c>active</c>, the Account can be used with the product flow that the
        /// Feature enables.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public AccountConfigurationRecipientDataFeatures Features { get; set; }
    }
}
