// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TermService : Service
    {
        private V2.Billing.Contracts.Terms.QuantityChangeService quantityChanges;

        internal TermService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TermService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.Contracts.Terms.QuantityChangeService QuantityChanges => this.quantityChanges ??= new V2.Billing.Contracts.Terms.QuantityChangeService(
            this.Requestor);

        /// <summary>
        /// List the terms on a contract, optionally filtered by type.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.ContractTerm> ListContractTerms(string id, TermListContractTermsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.ContractTerm>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/terms", options, requestOptions);
        }

        /// <summary>
        /// List the terms on a contract, optionally filtered by type.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.ContractTerm>> ListContractTermsAsync(string id, TermListContractTermsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.ContractTerm>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/terms", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List the terms on a contract, optionally filtered by type.
        /// </summary>
        public virtual IEnumerable<V2.Billing.ContractTerm> ListContractTermsAutoPaging(string id, TermListContractTermsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.ContractTerm>($"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/terms", options, requestOptions);
        }

        /// <summary>
        /// List the terms on a contract, optionally filtered by type.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.ContractTerm> ListContractTermsAutoPagingAsync(string id, TermListContractTermsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.ContractTerm>($"/v2/billing/contracts/{WebUtility.UrlEncode(id)}/terms", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a term on a contract.
        /// </summary>
        public virtual V2.Billing.ContractTerm RetrieveContractTerm(string parentId, string id, TermRetrieveContractTermOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.ContractTerm>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a term on a contract.
        /// </summary>
        public virtual Task<V2.Billing.ContractTerm> RetrieveContractTermAsync(string parentId, string id, TermRetrieveContractTermOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.ContractTerm>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/contracts/{WebUtility.UrlEncode(parentId)}/terms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
