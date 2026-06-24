// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilitiesBankAccounts : StripeEntity<AccountConfigurationRecipientCapabilitiesBankAccounts>
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over ACH rails.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsAch Ach { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over BECS
        /// rails.
        /// </summary>
        [JsonProperty("becs")]
        [STJS.JsonPropertyName("becs")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsBecs Becs { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over EFT rails.
        /// </summary>
        [JsonProperty("eft")]
        [STJS.JsonPropertyName("eft")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsEft Eft { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over Fedwire or
        /// CHIPS.
        /// </summary>
        [JsonProperty("fedwire")]
        [STJS.JsonPropertyName("fedwire")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsFedwire Fedwire { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over FPS rails.
        /// </summary>
        [JsonProperty("fps")]
        [STJS.JsonPropertyName("fps")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsFps Fps { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over real time
        /// rails.
        /// </summary>
        [JsonProperty("instant")]
        [STJS.JsonPropertyName("instant")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsInstant Instant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsLocal Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over NPP (real
        /// time) rails.
        /// </summary>
        [JsonProperty("npp")]
        [STJS.JsonPropertyName("npp")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsNpp Npp { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over RTP rails.
        /// </summary>
        [JsonProperty("rtp")]
        [STJS.JsonPropertyName("rtp")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsRtp Rtp { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SEPA
        /// credit rails.
        /// </summary>
        [JsonProperty("sepa_credit")]
        [STJS.JsonPropertyName("sepa_credit")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsSepaCredit SepaCredit { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SEPA
        /// instant (real time) rails.
        /// </summary>
        [JsonProperty("sepa_instant")]
        [STJS.JsonPropertyName("sepa_instant")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsSepaInstant SepaInstant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SWIFT.
        /// </summary>
        [JsonProperty("swift")]
        [STJS.JsonPropertyName("swift")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsSwift Swift { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
        [STJS.JsonPropertyName("wire")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsWire Wire { get; set; }
    }
}
