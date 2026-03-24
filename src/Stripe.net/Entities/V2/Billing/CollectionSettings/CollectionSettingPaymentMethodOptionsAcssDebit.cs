// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CollectionSettingPaymentMethodOptionsAcssDebit : StripeEntity<CollectionSettingPaymentMethodOptionsAcssDebit>
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public CollectionSettingPaymentMethodOptionsAcssDebitMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        [STJS.JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
