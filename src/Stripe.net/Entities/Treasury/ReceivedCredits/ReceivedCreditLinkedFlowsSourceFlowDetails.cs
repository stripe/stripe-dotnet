// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditLinkedFlowsSourceFlowDetails : StripeEntity<ReceivedCreditLinkedFlowsSourceFlowDetails>
    {
        /// <summary>
        /// You can reverse some <a
        /// href="https://api.stripe.com#received_credits">ReceivedCredits</a> depending on their
        /// network and source flow. Reversing a ReceivedCredit leads to the creation of a new
        /// object known as a CreditReversal.
        /// </summary>
        [JsonProperty("credit_reversal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_reversal")]
#endif
        public CreditReversal CreditReversal { get; set; }

        /// <summary>
        /// Use <a
        /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-payments">OutboundPayments</a>
        /// to send funds to another party's external bank account or <a
        /// href="https://api.stripe.com#financial_accounts">FinancialAccount</a>. To send money to
        /// an account belonging to the same user, use an <a
        /// href="https://api.stripe.com#outbound_transfers">OutboundTransfer</a>.
        ///
        /// Simulate OutboundPayment state changes with the
        /// <c>/v1/test_helpers/treasury/outbound_payments</c> endpoints. These methods can only be
        /// called on test mode objects.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-payments">Moving
        /// money with Treasury using OutboundPayment objects</a>.
        /// </summary>
        [JsonProperty("outbound_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment")]
#endif
        public OutboundPayment OutboundPayment { get; set; }

        /// <summary>
        /// Use <a
        /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-transfers">OutboundTransfers</a>
        /// to transfer funds from a <a
        /// href="https://api.stripe.com#financial_accounts">FinancialAccount</a> to a PaymentMethod
        /// belonging to the same entity. To send funds to a different party, use <a
        /// href="https://api.stripe.com#outbound_payments">OutboundPayments</a> instead. You can
        /// send funds over ACH rails or through a domestic wire transfer to a user's own external
        /// bank account.
        ///
        /// Simulate OutboundTransfer state changes with the
        /// <c>/v1/test_helpers/treasury/outbound_transfers</c> endpoints. These methods can only be
        /// called on test mode objects.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-transfers">Moving
        /// money with Treasury using OutboundTransfer objects</a>.
        /// </summary>
        [JsonProperty("outbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfer")]
#endif
        public OutboundTransfer OutboundTransfer { get; set; }

        /// <summary>
        /// A <c>Payout</c> object is created when you receive funds from Stripe, or when you
        /// initiate a payout to either a bank account or debit card of a <a
        /// href="https://stripe.com/docs/connect/bank-debit-card-payouts">connected Stripe
        /// account</a>. You can retrieve individual payouts, and list all payouts. Payouts are made
        /// on <a href="https://stripe.com/docs/connect/manage-payout-schedule">varying
        /// schedules</a>, depending on your country and industry.
        ///
        /// Related guide: <a href="https://docs.stripe.com/payouts">Receiving payouts</a>.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif
        public Payout Payout { get; set; }

        /// <summary>
        /// The type of the source flow that originated the ReceivedCredit.
        /// One of: <c>credit_reversal</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, or <c>payout</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
