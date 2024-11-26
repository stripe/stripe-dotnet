// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressIban : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressIban>
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The BIC/SWIFT code of the account.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif
        public string Bic { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The IBAN of the account.
        /// </summary>
        [JsonProperty("iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban")]
#endif
        public string Iban { get; set; }
    }
}
