// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantSepaDebitPayments : StripeEntity<AccountConfigurationMerchantSepaDebitPayments>
    {
        /// <summary>
        /// Creditor ID for SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("creditor_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("creditor_id")]
#endif
        public string CreditorId { get; set; }
    }
}
