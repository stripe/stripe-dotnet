// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsBenefit : StripeEntity<PaymentIntentPaymentDetailsBenefit>
    {
        [JsonProperty("fr_meal_voucher")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fr_meal_voucher")]
#endif
        public PaymentIntentPaymentDetailsBenefitFrMealVoucher FrMealVoucher { get; set; }
    }
}
