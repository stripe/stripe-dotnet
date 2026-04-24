// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AgreementService : Service
    {
        internal AgreementService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AgreementService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Confirm an Agreement.
        /// </summary>
        public virtual Agreement Confirm(string id, AgreementConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions);
        }

        /// <summary>
        /// Confirm an Agreement.
        /// </summary>
        public virtual Task<Agreement> ConfirmAsync(string id, AgreementConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a new Agreement.
        /// </summary>
        public virtual Agreement Create(AgreementCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements", options, requestOptions);
        }

        /// <summary>
        /// Create a new Agreement.
        /// </summary>
        public virtual Task<Agreement> CreateAsync(AgreementCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an Agreement by ID.
        /// </summary>
        public virtual Agreement Get(string id, AgreementGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Agreement>(BaseAddress.Api, HttpMethod.Get, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an Agreement by ID.
        /// </summary>
        public virtual Task<Agreement> GetAsync(string id, AgreementGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Agreement>(BaseAddress.Api, HttpMethod.Get, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Agreements for the profile associated with the authenticated merchant.
        /// </summary>
        public virtual V2.StripeList<Agreement> List(AgreementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Agreement>>(BaseAddress.Api, HttpMethod.Get, $"/v2/orchestrated_commerce/agreements", options, requestOptions);
        }

        /// <summary>
        /// List Agreements for the profile associated with the authenticated merchant.
        /// </summary>
        public virtual Task<V2.StripeList<Agreement>> ListAsync(AgreementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Agreement>>(BaseAddress.Api, HttpMethod.Get, $"/v2/orchestrated_commerce/agreements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Agreements for the profile associated with the authenticated merchant.
        /// </summary>
        public virtual IEnumerable<Agreement> ListAutoPaging(AgreementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Agreement>($"/v2/orchestrated_commerce/agreements", options, requestOptions);
        }

        /// <summary>
        /// List Agreements for the profile associated with the authenticated merchant.
        /// </summary>
        public virtual IAsyncEnumerable<Agreement> ListAutoPagingAsync(AgreementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Agreement>($"/v2/orchestrated_commerce/agreements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Terminate an Agreement.
        /// </summary>
        public virtual Agreement Terminate(string id, AgreementTerminateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}/terminate", options, requestOptions);
        }

        /// <summary>
        /// Terminate an Agreement.
        /// </summary>
        public virtual Task<Agreement> TerminateAsync(string id, AgreementTerminateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Agreement>(BaseAddress.Api, HttpMethod.Post, $"/v2/orchestrated_commerce/agreements/{WebUtility.UrlEncode(id)}/terminate", options, requestOptions, cancellationToken);
        }
    }
}
