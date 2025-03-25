// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountOther : StripeEntity<FinancialAccountOther>
    {
        /// <summary>
        /// The type of the FinancialAccount, represented as a string. Upgrade your API version to
        /// see the type reflected in <c>financial_account.type</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
