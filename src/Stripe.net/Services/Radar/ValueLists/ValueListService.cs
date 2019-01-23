namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ValueListService : Service<ValueList>,
        ICreatable<ValueList, ValueListCreateOptions>,
        IListable<ValueList, ValueListListOptions>,
        IRetrievable<ValueList>
    {
        public ValueListService()
            : base(null)
        {
        }

        public ValueListService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/radar/value_lists";

        public virtual ValueList Create(ValueListCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ValueList> CreateAsync(ValueListCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueList Delete(string valueListId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(valueListId, null, requestOptions);
        }

        public virtual Task<ValueList> DeleteAsync(string valueListId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(valueListId, null, requestOptions, cancellationToken);
        }

        public virtual ValueList Get(string valueListId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(valueListId, null, requestOptions);
        }

        public virtual Task<ValueList> GetAsync(string valueListId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(valueListId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueList> List(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ValueList>> ListAsync(ValueListListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ValueList> ListAutoPaging(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual ValueList Update(string valueListId, ValueListUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(valueListId, options, requestOptions);
        }

        public virtual Task<ValueList> UpdateAsync(string valueListId, ValueListUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(valueListId, options, requestOptions, cancellationToken);
        }
    }
}
