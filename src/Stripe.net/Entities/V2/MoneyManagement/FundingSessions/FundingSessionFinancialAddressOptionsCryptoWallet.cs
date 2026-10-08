// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingSessionFinancialAddressOptionsCryptoWallet : StripeEntity<FundingSessionFinancialAddressOptionsCryptoWallet>
    {
        /// <summary>
        /// Open Enum. The currency the crypto wallet FinancialAddress settles into the
        /// FinancialAccount. Required.
        /// </summary>
        [JsonProperty("settlement_currency")]
        [STJS.JsonPropertyName("settlement_currency")]
        public string SettlementCurrency { get; set; }
    }
}
