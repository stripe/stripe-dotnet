// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsSepaDebitPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// The business creditor id for european payments.
        /// </summary>
        [JsonProperty("creditor_id")]
        [STJS.JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }
    }
}
