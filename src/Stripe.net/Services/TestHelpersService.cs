// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestHelpersService : Service
    {
        private TestHelpers.CapitalService capital;
        private TestHelpers.ConfirmationTokenService confirmationTokens;
        private TestHelpers.CustomerService customers;
        private TestHelpers.IssuingService issuing;
        private TestHelpers.RefundService refunds;
        private TestHelpers.TerminalService terminal;
        private TestHelpers.TestClockService testClocks;
        private TestHelpers.TreasuryService treasury;

        internal TestHelpersService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TestHelpersService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.CapitalService Capital => this.capital ??= new TestHelpers.CapitalService(
            this.Requestor);

        public virtual TestHelpers.ConfirmationTokenService ConfirmationTokens => this.confirmationTokens ??= new TestHelpers.ConfirmationTokenService(
            this.Requestor);

        public virtual TestHelpers.CustomerService Customers => this.customers ??= new TestHelpers.CustomerService(
            this.Requestor);

        public virtual TestHelpers.IssuingService Issuing => this.issuing ??= new TestHelpers.IssuingService(
            this.Requestor);

        public virtual TestHelpers.RefundService Refunds => this.refunds ??= new TestHelpers.RefundService(
            this.Requestor);

        public virtual TestHelpers.TerminalService Terminal => this.terminal ??= new TestHelpers.TerminalService(
            this.Requestor);

        public virtual TestHelpers.TestClockService TestClocks => this.testClocks ??= new TestHelpers.TestClockService(
            this.Requestor);

        public virtual TestHelpers.TreasuryService Treasury => this.treasury ??= new TestHelpers.TreasuryService(
            this.Requestor);
    }
}
