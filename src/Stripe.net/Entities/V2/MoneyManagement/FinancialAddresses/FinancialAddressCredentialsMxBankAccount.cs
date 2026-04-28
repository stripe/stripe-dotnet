// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentialsMxBankAccount : StripeEntity<FinancialAddressCredentialsMxBankAccount>
    {
        /// <summary>
        /// The account holder name to be used during bank transfers.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The CLABE (Clave Bancaria Estandarizada) of the Mexican Bank Account.
        /// </summary>
        [JsonProperty("clabe")]
        [STJS.JsonPropertyName("clabe")]
        public string Clabe { get; set; }
    }
}
