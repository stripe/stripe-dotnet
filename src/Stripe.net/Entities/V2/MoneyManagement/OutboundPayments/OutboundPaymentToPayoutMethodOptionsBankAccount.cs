// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentToPayoutMethodOptionsBankAccount : StripeEntity<OutboundPaymentToPayoutMethodOptionsBankAccount>
    {
        /// <summary>
        /// Per-network configuration options.
        /// </summary>
        [JsonProperty("preferred_network_options")]
        [STJS.JsonPropertyName("preferred_network_options")]
        public OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions PreferredNetworkOptions { get; set; }

        /// <summary>
        /// The preferred networks to use for this OutboundPayment.
        /// One of: <c>ach</c>, <c>becs</c>, <c>eft</c>, <c>fedwire</c>, <c>fps</c>, <c>npp</c>,
        /// <c>rtp</c>, <c>sepa_credit</c>, <c>sepa_instant</c>, or <c>swift</c>.
        /// </summary>
        [JsonProperty("preferred_networks")]
        [STJS.JsonPropertyName("preferred_networks")]
        public List<string> PreferredNetworks { get; set; }
    }
}
