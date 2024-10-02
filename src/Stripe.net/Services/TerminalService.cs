// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TerminalService : Service
    {
        private Terminal.ConfigurationService configurations;
        private Terminal.ConnectionTokenService connectionTokens;
        private Terminal.LocationService locations;
        private Terminal.ReaderService readers;
        private Terminal.ReaderCollectedDataService readerCollectedData;

        internal TerminalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TerminalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Terminal.ConfigurationService Configurations => this.configurations ??= new Terminal.ConfigurationService(
            this.Requestor);

        public virtual Terminal.ConnectionTokenService ConnectionTokens => this.connectionTokens ??= new Terminal.ConnectionTokenService(
            this.Requestor);

        public virtual Terminal.LocationService Locations => this.locations ??= new Terminal.LocationService(
            this.Requestor);

        public virtual Terminal.ReaderService Readers => this.readers ??= new Terminal.ReaderService(
            this.Requestor);

        public virtual Terminal.ReaderCollectedDataService ReaderCollectedData => this.readerCollectedData ??= new Terminal.ReaderCollectedDataService(
            this.Requestor);
    }
}
