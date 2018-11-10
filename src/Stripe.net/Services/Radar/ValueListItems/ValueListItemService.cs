namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ValueListItemService : Service<ValueListItem>,
        ICreatable<ValueListItem, ValueListItemCreateOptions>,
        IListable<ValueListItem, ValueListItemListOptions>,
        IRetrievable<ValueListItem>
    {
        public ValueListItemService()
            : base(null)
        {
        }

        public ValueListItemService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/radar/value_list_items";

        public virtual ValueListItem Create(ValueListItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ValueListItem> CreateAsync(ValueListItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Delete(string couponId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(couponId, null, requestOptions);
        }

        public virtual Task<ValueListItem> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Get(string couponId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(couponId, null, requestOptions);
        }

        public virtual Task<ValueListItem> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueListItem> List(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ValueListItem>> ListAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }
    }
}
