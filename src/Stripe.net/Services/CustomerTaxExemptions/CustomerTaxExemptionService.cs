// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerTaxExemptionService : Service,
        INestedCreatable<CustomerTaxExemption, CustomerTaxExemptionCreateOptions>,
        INestedDeletable<CustomerTaxExemption, CustomerTaxExemptionDeleteOptions>,
        INestedListable<CustomerTaxExemption, CustomerTaxExemptionListOptions>,
        INestedRetrievable<CustomerTaxExemption, CustomerTaxExemptionGetOptions>
    {
        public CustomerTaxExemptionService()
        {
        }

        internal CustomerTaxExemptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerTaxExemptionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual CustomerTaxExemption Create(string parentId, CustomerTaxExemptionCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual Task<CustomerTaxExemption> CreateAsync(string parentId, CustomerTaxExemptionCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual CustomerTaxExemption Delete(string parentId, string id, CustomerTaxExemptionDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual Task<CustomerTaxExemption> DeleteAsync(string parentId, string id, CustomerTaxExemptionDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual CustomerTaxExemption Get(string parentId, string id, CustomerTaxExemptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a location specific tax exemption for a customer.</p>.
        /// </summary>
        public virtual Task<CustomerTaxExemption> GetAsync(string parentId, string id, CustomerTaxExemptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerTaxExemption>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all location specific tax exemptions for a customer.</p>.
        /// </summary>
        public virtual StripeList<CustomerTaxExemption> List(string parentId, CustomerTaxExemptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerTaxExemption>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions);
        }

        /// <summary>
        /// <p>List all location specific tax exemptions for a customer.</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerTaxExemption>> ListAsync(string parentId, CustomerTaxExemptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerTaxExemption>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all location specific tax exemptions for a customer.</p>.
        /// </summary>
        public virtual IEnumerable<CustomerTaxExemption> ListAutoPaging(string parentId, CustomerTaxExemptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerTaxExemption>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions);
        }

        /// <summary>
        /// <p>List all location specific tax exemptions for a customer.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerTaxExemption> ListAutoPagingAsync(string parentId, CustomerTaxExemptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerTaxExemption>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_exemptions", options, requestOptions, cancellationToken);
        }
    }
}
