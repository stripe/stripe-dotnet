// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingWalletStagedPurchaseMerchantOptions : INestedOptions
    {
        /// <summary>
        /// The merchant category code of the merchant.
        /// </summary>
        [JsonProperty("mcc")]
        [STJS.JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant's name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
