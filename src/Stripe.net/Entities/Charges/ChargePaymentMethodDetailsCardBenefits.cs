// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardBenefits : StripeEntity<ChargePaymentMethodDetailsCardBenefits>
    {
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public ChargePaymentMethodDetailsCardBenefitsFrMealVoucher FrMealVoucher { get; set; }

        /// <summary>
        /// Issuer of the benefit card utilized on this payment.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }
    }
}
