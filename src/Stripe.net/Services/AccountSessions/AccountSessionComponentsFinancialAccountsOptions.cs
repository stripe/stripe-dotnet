// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsFinancialAccountsOptions : INestedOptions
    {
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsFinancialAccountsFeaturesOptions Features { get; set; }
    }
}
