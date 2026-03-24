// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountListOptions : ListOptions
    {
        /// <summary>
        /// If present, only return accounts that belong to the specified account holder.
        /// <c>account_holder[customer]</c> and <c>account_holder[account]</c> are mutually
        /// exclusive.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AccountAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// If present, only return accounts that were collected as part of the given session.
        /// </summary>
        [JsonProperty("session")]
        [STJS.JsonPropertyName("session")]
        public string Session { get; set; }
    }
}
