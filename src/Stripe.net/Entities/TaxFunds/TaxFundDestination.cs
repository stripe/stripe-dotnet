// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxFundDestination : StripeEntity<TaxFundDestination>
    {
        /// <summary>
        /// Details about the payments balance side of the sweep.
        /// </summary>
        [JsonProperty("payments_balance")]
        [STJS.JsonPropertyName("payments_balance")]
        public TaxFundDestinationPaymentsBalance PaymentsBalance { get; set; }

        /// <summary>
        /// Details about the tax fund financial account side of the sweep.
        /// </summary>
        [JsonProperty("tax_fund_account")]
        [STJS.JsonPropertyName("tax_fund_account")]
        public TaxFundDestinationTaxFundAccount TaxFundAccount { get; set; }

        /// <summary>
        /// The type of account funds moved to or from. Either <c>payments_balance</c> or
        /// <c>tax_fund_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
