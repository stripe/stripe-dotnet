// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class IamService : Service
    {
        private V2.Iam.ApiKeyService apiKeys;

        internal IamService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IamService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Iam.ApiKeyService ApiKeys => this.apiKeys ??= new V2.Iam.ApiKeyService(
            this.Requestor);
    }
}
