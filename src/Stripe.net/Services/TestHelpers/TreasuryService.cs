// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TreasuryService : Service
    {
        private TestHelpers.Treasury.InboundTransferService inboundTransfers;
        private TestHelpers.Treasury.OutboundPaymentService outboundPayments;
        private TestHelpers.Treasury.OutboundTransferService outboundTransfers;
        private TestHelpers.Treasury.ReceivedCreditService receivedCredits;
        private TestHelpers.Treasury.ReceivedDebitService receivedDebits;

        internal TreasuryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TreasuryService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.Treasury.InboundTransferService InboundTransfers => this.inboundTransfers ??= new TestHelpers.Treasury.InboundTransferService(
            this.Requestor);

        public virtual TestHelpers.Treasury.OutboundPaymentService OutboundPayments => this.outboundPayments ??= new TestHelpers.Treasury.OutboundPaymentService(
            this.Requestor);

        public virtual TestHelpers.Treasury.OutboundTransferService OutboundTransfers => this.outboundTransfers ??= new TestHelpers.Treasury.OutboundTransferService(
            this.Requestor);

        public virtual TestHelpers.Treasury.ReceivedCreditService ReceivedCredits => this.receivedCredits ??= new TestHelpers.Treasury.ReceivedCreditService(
            this.Requestor);

        public virtual TestHelpers.Treasury.ReceivedDebitService ReceivedDebits => this.receivedDebits ??= new TestHelpers.Treasury.ReceivedDebitService(
            this.Requestor);
    }
}
