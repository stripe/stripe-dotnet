// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MandateService : Service<Mandate>,
        IRetrievable<Mandate, MandateGetOptions>
    {
        public MandateService()
        {
        }

        public MandateService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/mandates";

        /// <summary>
        /// <p>Retrieves a Mandate object.</p>.
        /// </summary>
        public virtual Mandate Get(string id, MandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Mandate>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieves a Mandate object.</p>.
        /// </summary>
        public virtual Task<Mandate> GetAsync(string id, MandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Mandate>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
