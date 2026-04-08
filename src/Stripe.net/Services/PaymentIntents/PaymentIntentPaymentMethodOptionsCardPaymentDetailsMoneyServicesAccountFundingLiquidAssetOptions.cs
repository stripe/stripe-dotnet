// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingLiquidAssetOptions : INestedOptions
    {
        /// <summary>
        /// Details for a cryptocurrency liquid asset funding transaction.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingLiquidAssetCryptoOptions Crypto { get; set; }

        /// <summary>
        /// Details for a security liquid asset funding transaction.
        /// </summary>
        [JsonProperty("security")]
        [STJS.JsonPropertyName("security")]
        public PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingLiquidAssetSecurityOptions Security { get; set; }
    }
}
