// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountBreB : StripeEntity<FinancialAddressBankAccountBreB>
    {
        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The BRE-B payment key.
        /// </summary>
        [JsonProperty("bre_b_key")]
        [STJS.JsonPropertyName("bre_b_key")]
        public string BreBKey { get; set; }
    }
}
