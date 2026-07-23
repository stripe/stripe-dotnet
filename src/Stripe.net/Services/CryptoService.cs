// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CryptoService : Service
    {
        private Crypto.CustomerService customers;
        private Crypto.DepositAddressService depositAddresses;
        private Crypto.OnrampSessionService onrampSessions;
        private Crypto.OnrampTransactionLimitsService onrampTransactionLimits;

        internal CryptoService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CryptoService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Crypto.CustomerService Customers => this.customers ??= new Crypto.CustomerService(
            this.Requestor);

        public virtual Crypto.DepositAddressService DepositAddresses => this.depositAddresses ??= new Crypto.DepositAddressService(
            this.Requestor);

        public virtual Crypto.OnrampSessionService OnrampSessions => this.onrampSessions ??= new Crypto.OnrampSessionService(
            this.Requestor);

        public virtual Crypto.OnrampTransactionLimitsService OnrampTransactionLimits => this.onrampTransactionLimits ??= new Crypto.OnrampTransactionLimitsService(
            this.Requestor);
    }
}
