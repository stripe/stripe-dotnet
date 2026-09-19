// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountClabe : StripeEntity<FinancialAddressBankAccountClabe>
    {
        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The CLABE interbank code.
        /// </summary>
        [JsonProperty("clabe")]
        [STJS.JsonPropertyName("clabe")]
        public string Clabe { get; set; }
    }
}
