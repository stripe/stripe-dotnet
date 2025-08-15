// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CadenceService : Service
    {
        internal CadenceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CadenceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel the billing cadence.
        /// </summary>
        public virtual Cadence Cancel(string id, CadenceCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel the billing cadence.
        /// </summary>
        public virtual Task<Cadence> CancelAsync(string id, CadenceCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a billing Cadence object.
        /// </summary>
        public virtual Cadence Create(CadenceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences", options, requestOptions);
        }

        /// <summary>
        /// Create a billing Cadence object.
        /// </summary>
        public virtual Task<Cadence> CreateAsync(CadenceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a billing Cadence object.
        /// </summary>
        public virtual Cadence Get(string id, CadenceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Cadence>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a billing Cadence object.
        /// </summary>
        public virtual Task<Cadence> GetAsync(string id, CadenceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cadence>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all the billing Cadences.
        /// </summary>
        public virtual V2.StripeList<Cadence> List(CadenceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Cadence>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences", options, requestOptions);
        }

        /// <summary>
        /// List all the billing Cadences.
        /// </summary>
        public virtual Task<V2.StripeList<Cadence>> ListAsync(CadenceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Cadence>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all the billing Cadences.
        /// </summary>
        public virtual IEnumerable<Cadence> ListAutoPaging(CadenceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Cadence>($"/v2/billing/cadences", options, requestOptions);
        }

        /// <summary>
        /// List all the billing Cadences.
        /// </summary>
        public virtual IAsyncEnumerable<Cadence> ListAutoPagingAsync(CadenceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Cadence>($"/v2/billing/cadences", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a billing Cadence object.
        /// </summary>
        public virtual Cadence Update(string id, CadenceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a billing Cadence object.
        /// </summary>
        public virtual Task<Cadence> UpdateAsync(string id, CadenceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Cadence>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
