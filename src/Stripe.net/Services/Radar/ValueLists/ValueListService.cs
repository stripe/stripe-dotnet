namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

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

        public override string BasePath => "/radar/value_lists";

        public virtual ValueList Create(ValueListCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ValueList> CreateAsync(ValueListCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueList Delete(string couponId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(couponId, null, requestOptions);
        }

        public virtual Task<ValueList> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual ValueList Get(string couponId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(couponId, null, requestOptions);
        }

        public virtual Task<ValueList> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueList> List(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ValueList>> ListAsync(ValueListListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueList Update(string couponId, ValueListUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(couponId, options, requestOptions);
        }

        public virtual Task<ValueList> UpdateAsync(string couponId, ValueListUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(couponId, options, requestOptions, cancellationToken);
        }
    }
}
