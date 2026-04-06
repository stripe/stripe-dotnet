// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletStagedPurchaseOptions : INestedOptions
    {
        /// <summary>
        /// The merchant where the staged wallet purchase is made.
        /// </summary>
        [JsonProperty("merchant")]
        [STJS.JsonPropertyName("merchant")]
        public PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletStagedPurchaseMerchantOptions Merchant { get; set; }
    }
}
