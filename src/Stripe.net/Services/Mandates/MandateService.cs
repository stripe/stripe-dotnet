// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MandateService : Service<Mandate>,
        IRetrievable<Mandate, MandateGetOptions>
    {
        public MandateService()
            : base(null)
        {
        }

        public MandateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/mandates";

        public virtual Mandate Get(string id, MandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Mandate>(HttpMethod.Get, $"/v1/mandates/{id}", options, requestOptions);
        }

        public virtual Task<Mandate> GetAsync(string id, MandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Mandate>(HttpMethod.Get, $"/v1/mandates/{id}", options, requestOptions, cancellationToken);
        }
    }
}
