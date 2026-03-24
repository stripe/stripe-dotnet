// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions : INestedOptions
    {
        /// <summary>
        /// Registered name of the business.
        /// </summary>
        [JsonProperty("registered_name")]
        [STJS.JsonPropertyName("registered_name")]
        public string RegisteredName { get; set; }
    }
}
