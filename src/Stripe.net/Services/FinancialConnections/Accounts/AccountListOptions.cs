// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountListOptions : ListOptions
    {
        /// <summary>
        /// If present, only return accounts that belong to the specified account holder.
        /// <c>account_holder[customer]</c> and <c>account_holder[account]</c> are mutually
        /// exclusive.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public AccountAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// If present, only return accounts that were collected as part of the given session.
        /// </summary>
        [JsonProperty("session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("session")]
#endif
        public string Session { get; set; }
    }
}
