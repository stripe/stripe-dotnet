// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateConfigurationRecipientDataOptions : INestedOptions
    {
        [JsonProperty("default_outbound_destination")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_outbound_destination")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalDefaultOutboundDestination { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDefaultOutboundDestination
        {
            get => this.InternalDefaultOutboundDestination?.Empty ?? false;
            set
            {
                this.InternalDefaultOutboundDestination ??= new Emptyable<string>();
                this.InternalDefaultOutboundDestination.Empty = value;
            }
        }

        /// <summary>
        /// The payout method id to be used as a default outbound destination. This will allow the
        /// PayoutMethod to be omitted on OutboundPayments made through API or sending payouts via
        /// dashboard. Can also be explicitly set to <c>null</c> to clear the existing default
        /// outbound destination.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DefaultOutboundDestination
        {
            get => this.InternalDefaultOutboundDestination?.Value;
            set
            {
                this.InternalDefaultOutboundDestination ??= new Emptyable<string>();
                this.InternalDefaultOutboundDestination.Value = value;
            }
        }

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
        public AccountUpdateConfigurationRecipientDataFeaturesOptions Features { get; set; }
    }
}
