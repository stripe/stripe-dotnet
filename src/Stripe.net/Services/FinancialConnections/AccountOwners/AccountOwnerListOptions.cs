// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountOwnerListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the ownership object to fetch owners from.
        /// </summary>
        [JsonProperty("ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership")]
#endif
        public string Ownership { get; set; }
    }
}
