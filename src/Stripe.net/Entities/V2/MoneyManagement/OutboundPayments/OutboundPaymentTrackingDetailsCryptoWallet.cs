// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetailsCryptoWallet : StripeEntity<OutboundPaymentTrackingDetailsCryptoWallet>
    {
        /// <summary>
        /// A unique identifier that can be used to track this OutboundPayment with the recipient
        /// crypto wallet.
        /// </summary>
        [JsonProperty("blockchain_transaction")]
        [STJS.JsonPropertyName("blockchain_transaction")]
        public string BlockchainTransaction { get; set; }
    }
}
