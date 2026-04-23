// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsSepaDebit : StripeEntity<GrantedTokenPaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Branch code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("branch_code")]
        [STJS.JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Information about the object that generated this PaymentMethod.
        /// </summary>
        [JsonProperty("generated_from")]
        [STJS.JsonPropertyName("generated_from")]
        public GrantedTokenPaymentMethodDetailsSepaDebitGeneratedFrom GeneratedFrom { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }
    }
}
