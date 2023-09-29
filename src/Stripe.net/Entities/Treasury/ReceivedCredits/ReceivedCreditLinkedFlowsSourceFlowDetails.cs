// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditLinkedFlowsSourceFlowDetails : StripeEntity<ReceivedCreditLinkedFlowsSourceFlowDetails>
    {
        /// <summary>
        /// You can reverse some <a
        /// href="https://stripe.com/docs/api#received_credits">ReceivedCredits</a> depending on
        /// their network and source flow. Reversing a ReceivedCredit leads to the creation of a new
        /// object known as a CreditReversal.
        /// </summary>
        [JsonProperty("credit_reversal")]
        public CreditReversal CreditReversal { get; set; }

        /// <summary>
        /// Use OutboundPayments to send funds to another party's external bank account or <a
        /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a>. To send
        /// money to an account belonging to the same user, use an <a
        /// href="https://stripe.com/docs/api#outbound_transfers">OutboundTransfer</a>.
        ///
        /// Simulate OutboundPayment state changes with the
        /// <c>/v1/test_helpers/treasury/outbound_payments</c> endpoints. These methods can only be
        /// called on test mode objects.
        /// </summary>
        [JsonProperty("outbound_payment")]
        public OutboundPayment OutboundPayment { get; set; }

        /// <summary>
        /// A <c>Payout</c> object is created when you receive funds from Stripe, or when you
        /// initiate a payout to either a bank account or debit card of a <a
        /// href="https://stripe.com/docs/connect/bank-debit-card-payouts">connected Stripe
        /// account</a>. You can retrieve individual payouts, and list all payouts. Payouts are made
        /// on <a href="https://stripe.com/docs/connect/manage-payout-schedule">varying
        /// schedules</a>, depending on your country and industry.
        ///
        /// Related guide: <a href="https://stripe.com/docs/payouts">Receiving payouts</a>.
        /// </summary>
        [JsonProperty("payout")]
        public Payout Payout { get; set; }

        /// <summary>
        /// The type of the source flow that originated the ReceivedCredit.
        /// One of: <c>credit_reversal</c>, <c>other</c>, <c>outbound_payment</c>, or <c>payout</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
