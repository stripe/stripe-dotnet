// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Controls when Stripe will attempt to debit the funds from the customer's account. The
        /// date must be a string in YYYY-MM-DD format. The date must be in the future and between 3
        /// and 15 calendar days from now.
        /// </summary>
        [JsonProperty("target_date")]
        [STJS.JsonPropertyName("target_date")]
        public string TargetDate { get; set; }
    }
}
