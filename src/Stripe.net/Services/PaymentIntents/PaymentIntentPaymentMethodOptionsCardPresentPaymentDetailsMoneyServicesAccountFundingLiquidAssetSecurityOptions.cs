// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingLiquidAssetSecurityOptions : INestedOptions
    {
        /// <summary>
        /// The security's ticker symbol (e.g. AAPL).
        /// </summary>
        [JsonProperty("ticker_symbol")]
        [STJS.JsonPropertyName("ticker_symbol")]
        public string TickerSymbol { get; set; }
    }
}
