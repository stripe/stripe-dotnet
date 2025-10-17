// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodBalanceBalance : StripeEntity<PaymentMethodBalanceBalance>
    {
        /// <summary>
        /// The available FR Meal Voucher balances.
        /// </summary>
        [JsonProperty("fr_meal_voucher")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fr_meal_voucher")]
#endif
        public PaymentMethodBalanceBalanceFrMealVoucher FrMealVoucher { get; set; }
    }
}
