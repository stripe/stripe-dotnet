namespace Stripe
{
    using System;
    using System.Collections.Generic;
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

        public virtual TaxId Create(string customerId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<TaxId> CreateAsync(string customerId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual TaxId Delete(string customerId, string taxIdId, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, taxIdId, options, requestOptions);
        }

        public virtual Task<TaxId> DeleteAsync(string customerId, string taxIdId, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(customerId, taxIdId, options, requestOptions, cancellationToken);
        }

        public virtual TaxId Get(string customerId, string taxIdId, TaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, taxIdId, options, requestOptions);
        }

        public virtual Task<TaxId> GetAsync(string customerId, string taxIdId, TaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(customerId, taxIdId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxId> List(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options, requestOptions);
        }

        public virtual Task<StripeList<TaxId>> ListAsync(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxId> ListAutoPaging(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<TaxId> ListAutoPagingAsync(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(customerId, options, requestOptions, cancellationToken);
        }
#endif
    }
}
