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
        /// One of: <c>business_custodial_storage.inbound.ousd</c>,
        /// <c>business_custodial_storage.inbound.usdc</c>,
        /// <c>business_custodial_storage.outbound.ousd</c>,
        /// <c>business_custodial_storage.outbound.usdc</c>, <c>business_storage.inbound.cad</c>,
        /// <c>business_storage.inbound.eur</c>, <c>business_storage.inbound.gbp</c>,
        /// <c>business_storage.inbound.ousd</c>, <c>business_storage.inbound.usd</c>,
        /// <c>business_storage.inbound.usdc</c>, <c>business_storage.outbound.cad</c>,
        /// <c>business_storage.outbound.eur</c>, <c>business_storage.outbound.gbp</c>,
        /// <c>business_storage.outbound.ousd</c>, <c>business_storage.outbound.usd</c>,
        /// <c>business_storage.outbound.usdc</c>, <c>consumer_storage.inbound.usd</c>,
        /// <c>consumer_storage.inbound.usdc</c>, <c>consumer_storage.outbound.usd</c>,
        /// <c>consumer_storage.outbound.usdc</c>, <c>inbound_transfers.bank_accounts</c>,
        /// <c>outbound_payments.bank_accounts</c>, <c>outbound_payments.cards</c>,
        /// <c>outbound_payments.crypto_wallets</c>, <c>outbound_payments.financial_accounts</c>,
        /// <c>outbound_payments.offramp.bank_accounts.brl</c>,
        /// <c>outbound_payments.offramp.bank_accounts.cop</c>,
        /// <c>outbound_payments.offramp.bank_accounts.eur</c>,
        /// <c>outbound_payments.offramp.bank_accounts.gbp</c>,
        /// <c>outbound_payments.offramp.bank_accounts.mxn</c>,
        /// <c>outbound_payments.offramp.bank_accounts.usd</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.brl</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.cop</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.eur</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.gbp</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.mxn</c>,
        /// <c>outbound_payments.onramp.crypto_wallets.usd</c>,
        /// <c>outbound_payments.paper_checks</c>, <c>outbound_transfers.bank_accounts</c>,
        /// <c>outbound_transfers.crypto_wallets</c>, <c>outbound_transfers.financial_accounts</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.brl</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.cop</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.eur</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.gbp</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.mxn</c>,
        /// <c>outbound_transfers.offramp.bank_accounts.usd</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.brl</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.cop</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.eur</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.gbp</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.mxn</c>,
        /// <c>outbound_transfers.onramp.crypto_wallets.usd</c>,
        /// <c>received_credits.bank_accounts</c>, <c>received_credits.crypto_wallets</c>,
        /// <c>received_credits.offramp.bank_accounts.brl</c>,
        /// <c>received_credits.offramp.bank_accounts.cop</c>,
        /// <c>received_credits.offramp.bank_accounts.eur</c>,
        /// <c>received_credits.offramp.bank_accounts.gbp</c>,
        /// <c>received_credits.offramp.bank_accounts.mxn</c>,
        /// <c>received_credits.offramp.bank_accounts.usd</c>,
        /// <c>received_credits.onramp.crypto_wallets.brl</c>,
        /// <c>received_credits.onramp.crypto_wallets.cop</c>,
        /// <c>received_credits.onramp.crypto_wallets.eur</c>,
        /// <c>received_credits.onramp.crypto_wallets.gbp</c>,
        /// <c>received_credits.onramp.crypto_wallets.mxn</c>,
        /// <c>received_credits.onramp.crypto_wallets.usd</c>, or
        /// <c>received_debits.bank_accounts</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("updated_capability")]
        [STJS.JsonPropertyName("updated_capability")]
        public string UpdatedCapability { get; set; }
    }
}
