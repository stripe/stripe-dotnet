// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountOther : StripeEntity<FinancialAccountOther>
    {
        /// <summary>
        /// The type of the FinancialAccount, represented as a string. Upgrade your API version to
        /// see the type reflected in <c>financial_account.type</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
