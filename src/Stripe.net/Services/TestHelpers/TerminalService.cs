// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TerminalService : Service
    {
        private TestHelpers.Terminal.ReaderService readers;

        internal TerminalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TerminalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.Terminal.ReaderService Readers => this.readers ??= new TestHelpers.Terminal.ReaderService(
            this.Requestor);
    }
}
