// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsBillie : StripeEntity<PaymentIntentPaymentMethodOptionsBillie>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("company_details")]
        [STJS.JsonPropertyName("company_details")]
        public PaymentIntentPaymentMethodOptionsBillieCompanyDetails CompanyDetails { get; set; }

        /// <summary>
        /// An identifier or reference that this payment corresponds to.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
