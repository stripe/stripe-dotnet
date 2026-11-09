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
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsLocal Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over RTP rails.
        /// </summary>
        [JsonProperty("rtp")]
        [STJS.JsonPropertyName("rtp")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsRtp Rtp { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SEPA
        /// rails.
        /// </summary>
        [JsonProperty("sepa")]
        [STJS.JsonPropertyName("sepa")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsSepa Sepa { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over SWIFT.
        /// </summary>
        [JsonProperty("swift")]
        [STJS.JsonPropertyName("swift")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsSwift Swift { get; set; }
    }
}
