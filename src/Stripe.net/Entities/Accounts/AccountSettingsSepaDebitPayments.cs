// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsSepaDebitPayments : StripeEntity<AccountSettingsSepaDebitPayments>
    {
        /// <summary>
        /// SEPA creditor identifier that identifies the company making the payment.
        /// </summary>
        [JsonProperty("creditor_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("creditor_id")]
#endif
        public string CreditorId { get; set; }
    }
}
