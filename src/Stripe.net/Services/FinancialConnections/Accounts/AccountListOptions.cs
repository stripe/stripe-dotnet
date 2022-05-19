// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class AccountListOptions : ListOptions
    {
        [JsonProperty("account_holder")]
        public AccountAccountHolderOptions AccountHolder { get; set; }

        [JsonProperty("session")]
        public string Session { get; set; }
    }
}
