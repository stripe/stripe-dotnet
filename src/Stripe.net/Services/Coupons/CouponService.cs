namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CouponService : Service<Coupon>,
        ICreatable<Coupon, CouponCreateOptions>,
        IDeletable<Coupon, CouponDeleteOptions>,
        IListable<Coupon, CouponListOptions>,
        IRetrievable<Coupon, CouponGetOptions>,
        IUpdatable<Coupon, CouponUpdateOptions>
    {
        public CouponService()
            : base(null)
        {
        }

        public CouponService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/coupons";

        public virtual Coupon Create(CouponCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Coupon> CreateAsync(CouponCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Coupon Delete(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<Coupon> DeleteAsync(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Coupon Get(string id, CouponGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Coupon> GetAsync(string id, CouponGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Coupon> List(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Coupon>> ListAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Coupon> ListAutoPaging(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Coupon> ListAutoPagingAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Coupon Update(string id, CouponUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Coupon> UpdateAsync(string id, CouponUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
