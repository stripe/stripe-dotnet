// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsEntryImpactRestrictsCapability : StripeEntity<AccountFutureRequirementsEntryImpactRestrictsCapability>
    {
        /// <summary>
        /// The name of the Capability which will be restricted.
        /// One of: <c>ach_debit_payments</c>, <c>acss_debit_payments</c>, <c>affirm_payments</c>,
        /// <c>afterpay_clearpay_payments</c>, <c>alma_payments</c>, <c>amazon_pay_payments</c>,
        /// <c>automatic_indirect_tax</c>, <c>au_becs_debit_payments</c>,
        /// <c>bacs_debit_payments</c>, <c>bancontact_payments</c>, <c>bank_accounts.instant</c>,
        /// <c>bank_accounts.local</c>, <c>bank_accounts.wire</c>, <c>blik_payments</c>,
        /// <c>boleto_payments</c>, <c>cards</c>, <c>card_payments</c>,
        /// <c>cartes_bancaires_payments</c>, <c>cashapp_payments</c>,
        /// <c>commercial.celtic.charge_card</c>, <c>commercial.celtic.spend_card</c>,
        /// <c>commercial.cross_river_bank.charge_card</c>,
        /// <c>commercial.cross_river_bank.prepaid_card</c>,
        /// <c>commercial.cross_river_bank.spend_card</c>,
        /// <c>commercial.fifth_third.charge_card</c>, <c>commercial.lead.prepaid_card</c>,
        /// <c>commercial.stripe.charge_card</c>, <c>commercial.stripe.prepaid_card</c>,
        /// <c>consumer.celtic.revolving_credit_card</c>,
        /// <c>consumer.cross_river_bank.prepaid_card</c>, <c>consumer.holds_currencies.usd</c>,
        /// <c>consumer.lead.prepaid_card</c>, <c>crypto_wallets</c>, <c>eps_payments</c>,
        /// <c>financial_addresses.bank_accounts</c>, <c>fpx_payments</c>,
        /// <c>gb_bank_transfer_payments</c>, <c>grabpay_payments</c>, <c>holds_currencies.eur</c>,
        /// <c>holds_currencies.gbp</c>, <c>holds_currencies.usd</c>, <c>ideal_payments</c>,
        /// <c>inbound_transfers.financial_accounts</c>, <c>jcb_payments</c>,
        /// <c>jp_bank_transfer_payments</c>, <c>kakao_pay_payments</c>, <c>klarna_payments</c>,
        /// <c>konbini_payments</c>, <c>kr_card_payments</c>, <c>link_payments</c>,
        /// <c>mobilepay_payments</c>, <c>multibanco_payments</c>, <c>mx_bank_transfer_payments</c>,
        /// <c>naver_pay_payments</c>, <c>outbound_payments.bank_accounts</c>,
        /// <c>outbound_payments.cards</c>, <c>outbound_payments.financial_accounts</c>,
        /// <c>outbound_transfers.bank_accounts</c>, <c>outbound_transfers.financial_accounts</c>,
        /// <c>oxxo_payments</c>, <c>p24_payments</c>, <c>payco_payments</c>,
        /// <c>paynow_payments</c>, <c>pay_by_bank_payments</c>, <c>promptpay_payments</c>,
        /// <c>revolut_pay_payments</c>, <c>samsung_pay_payments</c>,
        /// <c>sepa_bank_transfer_payments</c>, <c>sepa_debit_payments</c>,
        /// <c>stripe_balance.payouts</c>, <c>stripe_balance.stripe_transfers</c>,
        /// <c>swish_payments</c>, <c>twint_payments</c>, <c>us_bank_transfer_payments</c>, or
        /// <c>zip_payments</c>.
        /// </summary>
        [JsonProperty("capability")]
        [STJS.JsonPropertyName("capability")]
        public string Capability { get; set; }

        /// <summary>
        /// The configuration which specifies the Capability which will be restricted.
        /// One of: <c>card_creator</c>, <c>customer</c>, <c>merchant</c>, <c>recipient</c>, or
        /// <c>storer</c>.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// Details about when in the account lifecycle the requirement must be collected by the
        /// avoid the Capability restriction.
        /// </summary>
        [JsonProperty("deadline")]
        [STJS.JsonPropertyName("deadline")]
        public AccountFutureRequirementsEntryImpactRestrictsCapabilityDeadline Deadline { get; set; }
    }
}
