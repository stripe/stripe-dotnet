// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingLiquidAssetOptions liquidAsset;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Details for a liquid asset (crypto or security) funding transaction.
        /// </summary>
        [JsonProperty("liquid_asset", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("liquid_asset")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingLiquidAssetOptions LiquidAsset
        {
            get => this.liquidAsset;
            set
            {
                this.liquidAsset = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Details for a wallet funding transaction.
        /// </summary>
        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingWalletOptions Wallet { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
