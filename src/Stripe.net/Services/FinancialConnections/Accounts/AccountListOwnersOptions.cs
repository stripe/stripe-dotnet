// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class AccountListOwnersOptions : ListOptions
    {
        /// <summary>
        /// The ID of the ownership object to fetch owners from.
        /// </summary>
        [JsonProperty("ownership")]
        public string Ownership { get; set; }
    }
}
