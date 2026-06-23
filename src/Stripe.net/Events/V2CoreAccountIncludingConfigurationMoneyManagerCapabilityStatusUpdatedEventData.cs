// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>business_storage.inbound.eur</c>, <c>business_storage.inbound.gbp</c>,
        /// <c>business_storage.inbound.usd</c>, <c>business_storage.inbound.usdc</c>,
        /// <c>business_storage.outbound.eur</c>, <c>business_storage.outbound.gbp</c>,
        /// <c>business_storage.outbound.usd</c>, <c>business_storage.outbound.usdc</c>,
        /// <c>inbound_transfers.bank_accounts</c>, <c>outbound_payments.bank_accounts</c>,
        /// <c>outbound_payments.cards</c>, <c>outbound_payments.crypto_wallets</c>,
        /// <c>outbound_payments.financial_accounts</c>, <c>outbound_transfers.bank_accounts</c>,
        /// <c>outbound_transfers.crypto_wallets</c>, <c>outbound_transfers.financial_accounts</c>,
        /// <c>received_credits.bank_accounts</c>, <c>received_credits.crypto_wallets</c>, or
        /// <c>received_debits.bank_accounts</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
        [STJS.JsonPropertyName("updated_capability")]
        public string UpdatedCapability { get; set; }
    }
}
