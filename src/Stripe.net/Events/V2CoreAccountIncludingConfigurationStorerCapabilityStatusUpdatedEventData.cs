// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>consumer.holds_currencies.usd</c>, <c>financial_addressses.bank_accounts</c>,
        /// <c>financial_addressses.crypto_wallets</c>, <c>holds_currencies.eur</c>,
        /// <c>holds_currencies.gbp</c>, <c>holds_currencies.usd</c>, <c>holds_currencies.usdc</c>,
        /// <c>inbound_transfers.bank_accounts</c>, <c>outbound_payments.bank_accounts</c>,
        /// <c>outbound_payments.cards</c>, <c>outbound_payments.crypto_wallets</c>,
        /// <c>outbound_payments.financial_accounts</c>, <c>outbound_transfers.bank_accounts</c>,
        /// <c>outbound_transfers.crypto_wallets</c>, or
        /// <c>outbound_transfers.financial_accounts</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
        [STJS.JsonPropertyName("updated_capability")]
        public string UpdatedCapability { get; set; }
    }
}
