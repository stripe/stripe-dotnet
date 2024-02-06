// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxIdService : ServiceNested<TaxId>,
        INestedCreatable<TaxId, TaxIdCreateOptions>,
        INestedDeletable<TaxId, TaxIdDeleteOptions>,
        INestedListable<TaxId, TaxIdListOptions>,
        INestedRetrievable<TaxId, TaxIdGetOptions>
    {
        public TaxIdService()
            : base(null)
        {
        }

        public TaxIdService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/tax_ids";

        public virtual TaxId Create(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(HttpMethod.Post, $"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        public virtual Task<TaxId> CreateAsync(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(HttpMethod.Post, $"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }

        public virtual TaxId Delete(string parentId, string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(HttpMethod.Delete, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions);
        }

        public virtual Task<TaxId> DeleteAsync(string parentId, string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(HttpMethod.Delete, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions, cancellationToken);
        }

        public virtual TaxId Get(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions);
        }

        public virtual Task<TaxId> GetAsync(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxId> List(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxId>>(HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        public virtual Task<StripeList<TaxId>> ListAsync(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxId>>(HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxId> ListAutoPaging(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxId>($"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TaxId> ListAutoPagingAsync(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxId>($"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }
    }
}
