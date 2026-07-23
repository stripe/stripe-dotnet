// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServicesAccountFunding : StripeEntity<PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServicesAccountFunding>
    {
        /// <summary>
        /// The category of digital asset being acquired through this account funding transaction.
        /// One of: <c>blockchain_native</c>, <c>nft</c>, <c>other_non_fiat</c>, or
        /// <c>stablecoin</c>.
        /// </summary>
        [JsonProperty("digital_asset_category")]
        [STJS.JsonPropertyName("digital_asset_category")]
        public string DigitalAssetCategory { get; set; }
    }
}
