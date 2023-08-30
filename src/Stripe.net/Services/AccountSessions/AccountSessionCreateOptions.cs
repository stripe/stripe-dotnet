// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The identifier of the account to create an Account Session for.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Each key of the dictionary represents an embedded component, and each embedded component
        /// maps to its configuration (e.g. whether it has been enabled or not).
        /// </summary>
        [JsonProperty("components")]
        public AccountSessionComponentsOptions Components { get; set; }
    }
}
