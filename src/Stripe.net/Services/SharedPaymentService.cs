// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SharedPaymentService : Service
    {
        private SharedPayment.GrantedTokenService grantedTokens;
        private SharedPayment.IssuedTokenService issuedTokens;

        internal SharedPaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SharedPaymentService(IStripeClient client)
            : base(client)
        {
        }

        public virtual SharedPayment.GrantedTokenService GrantedTokens => this.grantedTokens ??= new SharedPayment.GrantedTokenService(
            this.Requestor);

        public virtual SharedPayment.IssuedTokenService IssuedTokens => this.issuedTokens ??= new SharedPayment.IssuedTokenService(
            this.Requestor);
    }
}
