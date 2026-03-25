// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentSetupDetailsBenefitOptions : INestedOptions, IHasSetTracking
    {
        private SetupIntentSetupDetailsBenefitFrMealVoucherOptions frMealVoucher;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// French meal voucher benefit details for this SetupIntent.
        /// </summary>
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public SetupIntentSetupDetailsBenefitFrMealVoucherOptions FrMealVoucher
        {
            get => this.frMealVoucher;
            set
            {
                this.frMealVoucher = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
