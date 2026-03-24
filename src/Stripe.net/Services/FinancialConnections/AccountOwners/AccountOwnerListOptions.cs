// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountOwnerListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the ownership object to fetch owners from.
        /// </summary>
        [JsonProperty("ownership")]
        [STJS.JsonPropertyName("ownership")]
        public string Ownership { get; set; }
    }
}
