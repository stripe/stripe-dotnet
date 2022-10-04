// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceService : Service<Balance>,
        ISingletonRetrievable<Balance>
    {
        public BalanceService()
            : base(null)
        {
        }

        public BalanceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/balance";

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.GetEntity(null, null, requestOptions);
        }

        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(null, null, requestOptions, cancellationToken);
        }
    }
}
