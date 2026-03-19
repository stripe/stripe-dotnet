// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsBenefitOptions : INestedOptions
    {
        /// <summary>
        /// French meal voucher benefit details for this PaymentIntent.
        /// </summary>
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions FrMealVoucher { get; set; }
    }
}
