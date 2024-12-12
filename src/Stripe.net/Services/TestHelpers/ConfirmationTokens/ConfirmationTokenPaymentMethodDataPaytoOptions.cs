// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodDataPaytoOptions : INestedOptions
    {
        /// <summary>
        /// The account number for the bank account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bsb_number")]
#endif
        public string BsbNumber { get; set; }

        /// <summary>
        /// The PayID alias for the bank account.
        /// </summary>
        [JsonProperty("pay_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_id")]
#endif
        public string PayId { get; set; }
    }
}
