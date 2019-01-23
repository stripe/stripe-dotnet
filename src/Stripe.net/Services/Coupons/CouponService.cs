namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CouponService : Service<Coupon>,
        ICreatable<Coupon, CouponCreateOptions>,
        IDeletable<Coupon>,
        IListable<Coupon, CouponListOptions>,
        IRetrievable<Coupon>,
        IUpdatable<Coupon, CouponUpdateOptions>
    {
        public CouponService()
            : base(null)
        {
        }

        public CouponService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/coupons";

        public virtual Coupon Create(CouponCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Coupon> CreateAsync(CouponCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Coupon Delete(string couponId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(couponId, null, requestOptions);
        }

        public virtual Task<Coupon> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual Coupon Get(string couponId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(couponId, null, requestOptions);
        }

        public virtual Task<Coupon> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(couponId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Coupon> List(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Coupon>> ListAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Coupon> ListAutoPaging(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Coupon Update(string couponId, CouponUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(couponId, options, requestOptions);
        }

        public virtual Task<Coupon> UpdateAsync(string couponId, CouponUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(couponId, options, requestOptions, cancellationToken);
        }
    }
}
