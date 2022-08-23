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
    }
}
