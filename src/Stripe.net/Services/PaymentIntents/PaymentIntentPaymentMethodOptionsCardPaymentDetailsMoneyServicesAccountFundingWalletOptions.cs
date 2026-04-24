// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletStagedPurchaseOptions stagedPurchase;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Details for a staged purchase.
        /// </summary>
        [JsonProperty("staged_purchase", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("staged_purchase")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletStagedPurchaseOptions StagedPurchase
        {
            get => this.stagedPurchase;
            set
            {
                this.stagedPurchase = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
