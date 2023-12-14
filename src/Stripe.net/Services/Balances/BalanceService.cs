// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
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

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public override string BasePath => "/v1/balance";

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.Request<Balance>(HttpMethod.Get, $"/v1/balance", null, requestOptions);
        }

        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Balance>(HttpMethod.Get, $"/v1/balance", null, requestOptions, cancellationToken);
        }

        public virtual Balance Get(BalanceGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Balance>(HttpMethod.Get, $"/v1/balance", options, requestOptions);
        }

        public virtual Task<Balance> GetAsync(BalanceGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Balance>(HttpMethod.Get, $"/v1/balance", options, requestOptions, cancellationToken);
        }
    }
}
