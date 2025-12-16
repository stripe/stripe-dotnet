// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SharedPaymentService : Service
    {
        private TestHelpers.SharedPayment.GrantedTokenService grantedTokens;

        internal SharedPaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SharedPaymentService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.SharedPayment.GrantedTokenService GrantedTokens => this.grantedTokens ??= new TestHelpers.SharedPayment.GrantedTokenService(
            this.Requestor);
    }
}
