// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBacsDebit : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBacsDebit>
    {
        /// <summary>
        /// Controls when Stripe will attempt to debit the funds from the customer's account. The
        /// date must be a string in YYYY-MM-DD format. The date must be in the future and between 3
        /// and 15 calendar days from now.
        /// </summary>
        [JsonProperty("target_date")]
        [STJS.JsonPropertyName("target_date")]
        public string TargetDate { get; set; }

        /// <summary>
        /// One of: <c>automatic</c>, or <c>payer_name_verification</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("verification_method")]
        [STJS.JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
