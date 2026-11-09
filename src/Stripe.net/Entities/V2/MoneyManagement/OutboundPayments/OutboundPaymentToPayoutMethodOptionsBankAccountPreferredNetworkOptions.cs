// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions : StripeEntity<OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions>
    {
        /// <summary>
        /// ACH-specific network options.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch Ach { get; set; }
    }
}
