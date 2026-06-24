// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestHelpersService : Service
    {
        private V2.MoneyManagement.TestHelpers.FinancialAddressService financialAddresses;

        internal TestHelpersService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TestHelpersService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.MoneyManagement.TestHelpers.FinancialAddressService FinancialAddresses => this.financialAddresses ??= new V2.MoneyManagement.TestHelpers.FinancialAddressService(
            this.Requestor);
    }
}
