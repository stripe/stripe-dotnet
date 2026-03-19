// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentSetupDetailsBenefitOptions : INestedOptions
    {
        /// <summary>
        /// French meal voucher benefit details for this SetupIntent.
        /// </summary>
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public SetupIntentSetupDetailsBenefitFrMealVoucherOptions FrMealVoucher { get; set; }
    }
}
