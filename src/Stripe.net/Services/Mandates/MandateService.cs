// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MandateService : Service,
        IListable<Mandate, MandateListOptions>,
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

        /// <summary>
        /// <p>Retrieves a list of Mandates for a given PaymentMethod.</p>.
        /// </summary>
        public virtual StripeList<Mandate> List(MandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Mandate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of Mandates for a given PaymentMethod.</p>.
        /// </summary>
        public virtual Task<StripeList<Mandate>> ListAsync(MandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Mandate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/mandates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of Mandates for a given PaymentMethod.</p>.
        /// </summary>
        public virtual IEnumerable<Mandate> ListAutoPaging(MandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Mandate>($"/v1/mandates", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of Mandates for a given PaymentMethod.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Mandate> ListAutoPagingAsync(MandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Mandate>($"/v1/mandates", options, requestOptions, cancellationToken);
        }
    }
}
