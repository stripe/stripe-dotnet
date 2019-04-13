namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxIdService : ServiceNested<TaxId>,
        INestedCreatable<TaxId, TaxIdCreateOptions>,
        INestedListable<TaxId, TaxIdListOptions>,
        INestedRetrievable<TaxId>
    {
        public TaxIdService()
            : base(null)
        {
        }

        public TaxIdService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/customers/{PARENT_ID}/tax_ids";

        public bool ExpandCustomer { get; set; }

        public virtual TaxId Create(string customerId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<TaxId> CreateAsync(string customerId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual TaxId Delete(string customerId, string taxIdId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, taxIdId, null, requestOptions);
        }

        public virtual Task<TaxId> DeleteAsync(string customerId, string taxIdId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(customerId, taxIdId, null, requestOptions, cancellationToken);
        }

        public virtual TaxId Get(string customerId, string taxIdId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, taxIdId, null, requestOptions);
        }

        public virtual Task<TaxId> GetAsync(string customerId, string taxIdId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(customerId, taxIdId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxId> List(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options, requestOptions);
        }

        public virtual Task<StripeList<TaxId>> ListAsync(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxId> ListAutoPaging(string customerId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options, requestOptions);
        }
    }
}
