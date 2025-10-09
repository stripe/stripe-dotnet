// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentSetupDetailsBenefit : StripeEntity<SetupIntentSetupDetailsBenefit>
    {
        [JsonProperty("fr_meal_voucher")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fr_meal_voucher")]
#endif
        public SetupIntentSetupDetailsBenefitFrMealVoucher FrMealVoucher { get; set; }
    }
}
