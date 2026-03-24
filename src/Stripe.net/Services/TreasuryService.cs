// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TreasuryService : Service
    {
        private Treasury.CreditReversalService creditReversals;
        private Treasury.DebitReversalService debitReversals;
        private Treasury.FinancialAccountService financialAccounts;
        private Treasury.InboundTransferService inboundTransfers;
        private Treasury.OutboundPaymentService outboundPayments;
        private Treasury.OutboundTransferService outboundTransfers;
        private Treasury.ReceivedCreditService receivedCredits;
        private Treasury.ReceivedDebitService receivedDebits;
        private Treasury.TransactionService transactions;
        private Treasury.TransactionEntryService transactionEntries;

        internal TreasuryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TreasuryService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Treasury.CreditReversalService CreditReversals => this.creditReversals ??= new Treasury.CreditReversalService(
            this.Requestor);

        public virtual Treasury.DebitReversalService DebitReversals => this.debitReversals ??= new Treasury.DebitReversalService(
            this.Requestor);

        public virtual Treasury.FinancialAccountService FinancialAccounts => this.financialAccounts ??= new Treasury.FinancialAccountService(
            this.Requestor);

        public virtual Treasury.InboundTransferService InboundTransfers => this.inboundTransfers ??= new Treasury.InboundTransferService(
            this.Requestor);

        public virtual Treasury.OutboundPaymentService OutboundPayments => this.outboundPayments ??= new Treasury.OutboundPaymentService(
            this.Requestor);

        public virtual Treasury.OutboundTransferService OutboundTransfers => this.outboundTransfers ??= new Treasury.OutboundTransferService(
            this.Requestor);

        public virtual Treasury.ReceivedCreditService ReceivedCredits => this.receivedCredits ??= new Treasury.ReceivedCreditService(
            this.Requestor);

        public virtual Treasury.ReceivedDebitService ReceivedDebits => this.receivedDebits ??= new Treasury.ReceivedDebitService(
            this.Requestor);

        public virtual Treasury.TransactionService Transactions => this.transactions ??= new Treasury.TransactionService(
            this.Requestor);

        public virtual Treasury.TransactionEntryService TransactionEntries => this.transactionEntries ??= new Treasury.TransactionEntryService(
            this.Requestor);
    }
}
