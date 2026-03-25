// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsBenefitOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions frMealVoucher;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// French meal voucher benefit details for this PaymentIntent.
        /// </summary>
        [JsonProperty("fr_meal_voucher")]
        [STJS.JsonPropertyName("fr_meal_voucher")]
        public PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions FrMealVoucher
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
