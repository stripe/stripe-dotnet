// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class TransactionFlowDetails : StripeEntity<TransactionFlowDetails>
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
        /// You can reverse some <a
        /// href="https://stripe.com/docs/api#received_debits">ReceivedDebits</a> depending on their
        /// network and source flow. Reversing a ReceivedDebit leads to the creation of a new object
        /// known as a DebitReversal.
        /// </summary>
        [JsonProperty("debit_reversal")]
        public DebitReversal DebitReversal { get; set; }

        /// <summary>
        /// Use <a
        /// href="https://stripe.com/docs/treasury/moving-money/financial-accounts/into/inbound-transfers">InboundTransfers</a>
        /// to add funds to your <a
        /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a> via a
        /// PaymentMethod that is owned by you. The funds will be transferred via an ACH debit.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        public InboundTransfer InboundTransfer { get; set; }

        /// <summary>
        /// When an <a href="https://stripe.com/docs/issuing">issued card</a> is used to make a
        /// purchase, an Issuing <c>Authorization</c> object is created. <a
        /// href="https://stripe.com/docs/issuing/purchases/authorizations">Authorizations</a> must
        /// be approved for the purchase to be completed successfully.
        ///
        /// Related guide: <a href="https://stripe.com/docs/issuing/purchases/authorizations">Issued
        /// card authorizations</a>.
        /// </summary>
        [JsonProperty("issuing_authorization")]
        public Issuing.Authorization IssuingAuthorization { get; set; }

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
        /// Use OutboundTransfers to transfer funds from a <a
        /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a> to a
        /// PaymentMethod belonging to the same entity. To send funds to a different party, use <a
        /// href="https://stripe.com/docs/api#outbound_payments">OutboundPayments</a> instead. You
        /// can send funds over ACH rails or through a domestic wire transfer to a user's own
        /// external bank account.
        ///
        /// Simulate OutboundTransfer state changes with the
        /// <c>/v1/test_helpers/treasury/outbound_transfers</c> endpoints. These methods can only be
        /// called on test mode objects.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        public OutboundTransfer OutboundTransfer { get; set; }

        /// <summary>
        /// ReceivedCredits represent funds sent to a <a
        /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a> (for example,
        /// via ACH or wire). These money movements are not initiated from the FinancialAccount.
        /// </summary>
        [JsonProperty("received_credit")]
        public ReceivedCredit ReceivedCredit { get; set; }

        /// <summary>
        /// ReceivedDebits represent funds pulled from a <a
        /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a>. These are
        /// not initiated from the FinancialAccount.
        /// </summary>
        [JsonProperty("received_debit")]
        public ReceivedDebit ReceivedDebit { get; set; }

        /// <summary>
        /// Type of the flow that created the Transaction. Set to the same value as
        /// <c>flow_type</c>.
        /// One of: <c>credit_reversal</c>, <c>debit_reversal</c>, <c>inbound_transfer</c>,
        /// <c>issuing_authorization</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
