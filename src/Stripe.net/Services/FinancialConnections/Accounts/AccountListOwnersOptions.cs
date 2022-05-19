// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class AccountListOwnersOptions : ListOptions
    {
        [JsonProperty("ownership")]
        public string Ownership { get; set; }
    }
}
