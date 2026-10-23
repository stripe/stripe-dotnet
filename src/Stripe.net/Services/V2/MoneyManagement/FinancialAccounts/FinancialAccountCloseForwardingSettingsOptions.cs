// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCloseForwardingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// ID of the FinancialAccount that supplies funds to cover negative balances during or
        /// after this FinancialAccount's closure.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// ID of the FinancialAccount that receives funds forwarded from this FinancialAccount when
        /// it closes.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// Whether to skip forwarding exportable self-custodied wallet balances. Defaults to false.
        /// This does not skip non-exportable or fiat balances, inbound-pending checks, or
        /// negative-balance requirements.
        /// </summary>
        [JsonProperty("skip_exportable_balances")]
        [STJS.JsonPropertyName("skip_exportable_balances")]
        public bool? SkipExportableBalances { get; set; }
    }
}
