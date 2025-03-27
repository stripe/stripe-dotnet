// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MandateService : Service,
        IRetrievable<Mandate, MandateGetOptions>
    {
        public MandateService()
        {
        }

        internal MandateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public MandateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a Mandate object.</p>.
        /// </summary>
        public virtual Mandate Get(string id, MandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Mandate>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Mandate object.</p>.
        /// </summary>
        public virtual Task<Mandate> GetAsync(string id, MandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Mandate>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
