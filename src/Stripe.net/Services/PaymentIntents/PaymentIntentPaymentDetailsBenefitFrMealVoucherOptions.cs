// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions : INestedOptions
    {
        /// <summary>
        /// Whether to enable meal voucher benefit for this payment.
        /// One of: <c>if_payment_method_is_eligible</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public string Enabled { get; set; }

        /// <summary>
        /// The 14-digit SIRET of the meal voucher acceptor.
        /// </summary>
        [JsonProperty("siret")]
        [STJS.JsonPropertyName("siret")]
        public string Siret { get; set; }
    }
}
