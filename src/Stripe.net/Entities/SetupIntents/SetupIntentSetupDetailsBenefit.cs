// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentSetupDetailsBenefit : StripeEntity<SetupIntentSetupDetailsBenefit>
    {
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public SetupIntentSetupDetailsBenefitFrMealVoucher FrMealVoucher { get; set; }
    }
}
