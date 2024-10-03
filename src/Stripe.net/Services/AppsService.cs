// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AppsService : Service
    {
        private Apps.SecretService secrets;

        internal AppsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AppsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Apps.SecretService Secrets => this.secrets ??= new Apps.SecretService(
            this.Requestor);
    }
}
