// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class AcceptedFinancingService : Service<AcceptedFinancing>,
        ISingletonRetrievable<AcceptedFinancing>
    {
        public AcceptedFinancingService()
            : base(null)
        {
        }

        public AcceptedFinancingService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/capital/financing/accepted";

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public virtual AcceptedFinancing Get(RequestOptions requestOptions = null)
        {
            return this.GetEntity(null, null, requestOptions);
        }

        public virtual Task<AcceptedFinancing> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(null, null, requestOptions, cancellationToken);
        }
    }
}
