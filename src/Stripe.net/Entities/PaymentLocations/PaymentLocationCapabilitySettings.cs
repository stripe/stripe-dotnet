// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapabilitySettings : StripeEntity<PaymentLocationCapabilitySettings>
    {
        /// <summary>
        /// Settings for Conecs French meal voucher capability.
        /// </summary>
        [JsonProperty("fr_meal_vouchers_conecs_payments")]
        [STJS.JsonPropertyName("fr_meal_vouchers_conecs_payments")]
        public PaymentLocationCapabilitySettingsFrMealVouchersConecsPayments FrMealVouchersConecsPayments { get; set; }
    }
}
