// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteToPayoutMethodOptionsBankAccountPreferredNetworkOptions : StripeEntity<OutboundPaymentQuoteToPayoutMethodOptionsBankAccountPreferredNetworkOptions>
    {
        /// <summary>
        /// ACH-specific network options.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public OutboundPaymentQuoteToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch Ach { get; set; }
    }
}
