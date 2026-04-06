// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingLiquidAssetCryptoOptions : INestedOptions
    {
        /// <summary>
        /// The cryptocurrency currency code (e.g. BTC, ETH).
        /// </summary>
        [JsonProperty("currency_code")]
        [STJS.JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
