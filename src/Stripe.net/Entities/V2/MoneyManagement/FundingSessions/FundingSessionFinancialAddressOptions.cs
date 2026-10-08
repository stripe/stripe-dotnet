// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingSessionFinancialAddressOptions : StripeEntity<FundingSessionFinancialAddressOptions>
    {
        /// <summary>
        /// Options for a crypto wallet FinancialAddress. Required if <c>crypto_wallet</c> is
        /// requested.
        /// </summary>
        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public FundingSessionFinancialAddressOptionsCryptoWallet CryptoWallet { get; set; }
    }
}
