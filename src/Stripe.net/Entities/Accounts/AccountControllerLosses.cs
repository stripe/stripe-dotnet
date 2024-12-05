// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerLosses : StripeEntity<AccountControllerLosses>
    {
        /// <summary>
        /// A value indicating who is liable when this account can't pay back negative balances from
        /// payments.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("payments")]
        public string Payments { get; set; }
    }
}
