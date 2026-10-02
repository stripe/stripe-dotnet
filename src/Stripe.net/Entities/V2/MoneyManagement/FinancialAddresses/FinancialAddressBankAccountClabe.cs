// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountClabe : StripeEntity<FinancialAddressBankAccountClabe>
    {
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("clabe")]
        [STJS.JsonPropertyName("clabe")]
        public string Clabe { get; set; }
    }
}
