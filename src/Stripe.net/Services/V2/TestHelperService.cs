// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestHelperService : Service
    {
        private V2.TestHelpers.FinancialAddressService financialAddresses;

        internal TestHelperService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TestHelperService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.TestHelpers.FinancialAddressService FinancialAddresses => this.financialAddresses ??= new V2.TestHelpers.FinancialAddressService(
            this.Requestor);
    }
}
