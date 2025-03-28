// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class MoneyManagementService : Service
    {
        private V2.MoneyManagement.AdjustmentService adjustments;
        private V2.MoneyManagement.FinancialAccountService financialAccounts;
        private V2.MoneyManagement.FinancialAddressService financialAddresses;
        private V2.MoneyManagement.InboundTransferService inboundTransfers;
        private V2.MoneyManagement.OutboundPaymentService outboundPayments;
        private V2.MoneyManagement.OutboundPaymentQuoteService outboundPaymentQuotes;
        private V2.MoneyManagement.OutboundTransferService outboundTransfers;
        private V2.MoneyManagement.OutboundSetupIntentService outboundSetupIntents;
        private V2.MoneyManagement.PayoutMethodService payoutMethods;
        private V2.MoneyManagement.PayoutMethodsBankAccountSpecService payoutMethodsBankAccountSpec;
        private V2.MoneyManagement.ReceivedCreditService receivedCredits;
        private V2.MoneyManagement.ReceivedDebitService receivedDebits;
        private V2.MoneyManagement.TransactionService transactions;
        private V2.MoneyManagement.TransactionEntryService transactionEntries;

        internal MoneyManagementService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MoneyManagementService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.MoneyManagement.AdjustmentService Adjustments => this.adjustments ??= new V2.MoneyManagement.AdjustmentService(
            this.Requestor);

        public virtual V2.MoneyManagement.FinancialAccountService FinancialAccounts => this.financialAccounts ??= new V2.MoneyManagement.FinancialAccountService(
            this.Requestor);

        public virtual V2.MoneyManagement.FinancialAddressService FinancialAddresses => this.financialAddresses ??= new V2.MoneyManagement.FinancialAddressService(
            this.Requestor);

        public virtual V2.MoneyManagement.InboundTransferService InboundTransfers => this.inboundTransfers ??= new V2.MoneyManagement.InboundTransferService(
            this.Requestor);

        public virtual V2.MoneyManagement.OutboundPaymentService OutboundPayments => this.outboundPayments ??= new V2.MoneyManagement.OutboundPaymentService(
            this.Requestor);

        public virtual V2.MoneyManagement.OutboundPaymentQuoteService OutboundPaymentQuotes => this.outboundPaymentQuotes ??= new V2.MoneyManagement.OutboundPaymentQuoteService(
            this.Requestor);

        public virtual V2.MoneyManagement.OutboundTransferService OutboundTransfers => this.outboundTransfers ??= new V2.MoneyManagement.OutboundTransferService(
            this.Requestor);

        public virtual V2.MoneyManagement.OutboundSetupIntentService OutboundSetupIntents => this.outboundSetupIntents ??= new V2.MoneyManagement.OutboundSetupIntentService(
            this.Requestor);

        public virtual V2.MoneyManagement.PayoutMethodService PayoutMethods => this.payoutMethods ??= new V2.MoneyManagement.PayoutMethodService(
            this.Requestor);

        public virtual V2.MoneyManagement.PayoutMethodsBankAccountSpecService PayoutMethodsBankAccountSpec => this.payoutMethodsBankAccountSpec ??= new V2.MoneyManagement.PayoutMethodsBankAccountSpecService(
            this.Requestor);

        public virtual V2.MoneyManagement.ReceivedCreditService ReceivedCredits => this.receivedCredits ??= new V2.MoneyManagement.ReceivedCreditService(
            this.Requestor);

        public virtual V2.MoneyManagement.ReceivedDebitService ReceivedDebits => this.receivedDebits ??= new V2.MoneyManagement.ReceivedDebitService(
            this.Requestor);

        public virtual V2.MoneyManagement.TransactionService Transactions => this.transactions ??= new V2.MoneyManagement.TransactionService(
            this.Requestor);

        public virtual V2.MoneyManagement.TransactionEntryService TransactionEntries => this.transactionEntries ??= new V2.MoneyManagement.TransactionEntryService(
            this.Requestor);
    }
}
