// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ContractService : Service
    {
        private V2.Billing.Contracts.PricingLinesService pricingLines;

        internal ContractService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ContractService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.Contracts.PricingLinesService PricingLines => this.pricingLines ??= new V2.Billing.Contracts.PricingLinesService(
            this.Requestor);

        /// <summary>
        /// Activate a Draft Contract object by ID.
        /// </summary>
        public virtual Contract Activate(string id, ContractActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/activate", options, requestOptions);
        }

        /// <summary>
        /// Activate a Draft Contract object by ID.
        /// </summary>
        public virtual Task<Contract> ActivateAsync(string id, ContractActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Cancel a Contract object by ID.
        /// </summary>
        public virtual Contract Cancel(string id, ContractCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel a Contract object by ID.
        /// </summary>
        public virtual Task<Contract> CancelAsync(string id, ContractCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a Contract object.
        /// </summary>
        public virtual Contract Create(ContractCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts", options, requestOptions);
        }

        /// <summary>
        /// Create a Contract object.
        /// </summary>
        public virtual Task<Contract> CreateAsync(ContractCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Delete a draft Contract object by ID.
        /// </summary>
        public virtual V2.DeletedObject Delete(string id, ContractDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Delete a draft Contract object by ID.
        /// </summary>
        public virtual Task<V2.DeletedObject> DeleteAsync(string id, ContractDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Contract object by ID.
        /// </summary>
        public virtual Contract Get(string id, ContractGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Contract>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Contract object by ID.
        /// </summary>
        public virtual Task<Contract> GetAsync(string id, ContractGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Contract>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Contract objects with pagination.
        /// </summary>
        public virtual V2.StripeList<Contract> List(ContractListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Contract>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts", options, requestOptions);
        }

        /// <summary>
        /// List Contract objects with pagination.
        /// </summary>
        public virtual Task<V2.StripeList<Contract>> ListAsync(ContractListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Contract>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Contract objects with pagination.
        /// </summary>
        public virtual IEnumerable<Contract> ListAutoPaging(ContractListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Contract>($"/v2/billing/contracts", options, requestOptions);
        }

        /// <summary>
        /// List Contract objects with pagination.
        /// </summary>
        public virtual IAsyncEnumerable<Contract> ListAutoPagingAsync(ContractListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Contract>($"/v2/billing/contracts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Contract object by ID.
        /// </summary>
        public virtual Contract Update(string id, ContractUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Contract object by ID.
        /// </summary>
        public virtual Task<Contract> UpdateAsync(string id, ContractUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Contract>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
