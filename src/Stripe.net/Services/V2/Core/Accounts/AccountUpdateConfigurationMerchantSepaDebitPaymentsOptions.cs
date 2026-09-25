// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMerchantSepaDebitPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Creditor ID for SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("creditor_id")]
        [STJS.JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }
    }
}
