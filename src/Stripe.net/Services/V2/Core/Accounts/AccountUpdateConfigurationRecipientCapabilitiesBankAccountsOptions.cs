// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationRecipientCapabilitiesBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over ACH rails.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsAchOptions Ach { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over BECS
        /// rails.
        /// </summary>
        [JsonProperty("becs")]
        [STJS.JsonPropertyName("becs")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsBecsOptions Becs { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over EFT rails.
        /// </summary>
        [JsonProperty("eft")]
        [STJS.JsonPropertyName("eft")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsEftOptions Eft { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over Fedwire or
        /// CHIPS.
        /// </summary>
        [JsonProperty("fedwire")]
        [STJS.JsonPropertyName("fedwire")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsFedwireOptions Fedwire { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over FPS rails.
        /// </summary>
        [JsonProperty("fps")]
        [STJS.JsonPropertyName("fps")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsFpsOptions Fps { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over real time
        /// rails.
        /// </summary>
        [JsonProperty("instant")]
        [STJS.JsonPropertyName("instant")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsInstantOptions Instant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsLocalOptions Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over NPP (real
        /// time) rails.
        /// </summary>
        [JsonProperty("npp")]
        [STJS.JsonPropertyName("npp")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsNppOptions Npp { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over RTP rails.
        /// </summary>
        [JsonProperty("rtp")]
        [STJS.JsonPropertyName("rtp")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsRtpOptions Rtp { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SEPA
        /// credit rails.
        /// </summary>
        [JsonProperty("sepa_credit")]
        [STJS.JsonPropertyName("sepa_credit")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsSepaCreditOptions SepaCredit { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SEPA
        /// instant (real time) rails.
        /// </summary>
        [JsonProperty("sepa_instant")]
        [STJS.JsonPropertyName("sepa_instant")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsSepaInstantOptions SepaInstant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SWIFT.
        /// </summary>
        [JsonProperty("swift")]
        [STJS.JsonPropertyName("swift")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsSwiftOptions Swift { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
        [STJS.JsonPropertyName("wire")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsWireOptions Wire { get; set; }
    }
}
