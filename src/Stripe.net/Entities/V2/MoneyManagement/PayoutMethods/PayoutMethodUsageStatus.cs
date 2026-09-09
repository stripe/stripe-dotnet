// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodUsageStatus : StripeEntity<PayoutMethodUsageStatus>
    {
        /// <summary>
        /// Payments status - used when sending OutboundPayments (sending funds to recipients). If
        /// disabled, enable the payout method by creating an OutboundSetupIntent using <a
        /// href="https://docs.stripe.com/api/v2/money-management/outbound-setup-intents/create"><c>POST
        /// /v2/money_management/outbound_setup_intents</c></a>.
        /// One of: <c>disabled</c>, <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public string Payments { get; set; }

        /// <summary>
        /// Transfers status - used when making an OutboundTransfer (sending funds to yourself). If
        /// disabled, enable the payout method by creating an OutboundSetupIntent using <a
        /// href="https://docs.stripe.com/api/v2/money-management/outbound-setup-intents/create"><c>POST
        /// /v2/money_management/outbound_setup_intents</c></a>.
        /// One of: <c>disabled</c>, <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("transfers")]
        [STJS.JsonPropertyName("transfers")]
        public string Transfers { get; set; }
    }
}
