// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerLossesOptions : INestedOptions
    {
        /// <summary>
        /// A value indicating who is liable when this account can't pay back negative balances
        /// resulting from payments. Defaults to <c>stripe</c>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("payments")]
        public string Payments { get; set; }
    }
}
