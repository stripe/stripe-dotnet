// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerPaymentTokenUsBankAccount : StripeEntity<CustomerPaymentTokenUsBankAccount>
    {
        /// <summary>
        /// Account type: <c>checkings</c> or <c>savings</c>.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
        [STJS.JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }
    }
}
