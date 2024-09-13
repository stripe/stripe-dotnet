namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountControllerLosses : StripeEntity<AccountControllerLosses>
    {
        /// <summary>
        /// A value indicating who is liable when this account can't pay back negative balances from
        /// payments.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("payments")]
#else
        [JsonProperty("payments")]
#endif
        public string Payments { get; set; }
    }
}
