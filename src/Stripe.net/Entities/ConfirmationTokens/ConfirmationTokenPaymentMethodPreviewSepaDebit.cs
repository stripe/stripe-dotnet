// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewSepaDebit : StripeEntity<ConfirmationTokenPaymentMethodPreviewSepaDebit>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// Branch code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif
        public string BranchCode { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Information about the object that generated this PaymentMethod.
        /// </summary>
        [JsonProperty("generated_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_from")]
#endif
        public ConfirmationTokenPaymentMethodPreviewSepaDebitGeneratedFrom GeneratedFrom { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }
    }
}
