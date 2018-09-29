namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

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

        public virtual Coupon Create(CouponCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/coupons", requestOptions, options);
        }

        public virtual Task<Coupon> CreateAsync(CouponCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/coupons", requestOptions, cancellationToken, options);
        }

        public virtual Coupon Delete(string couponId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions);
        }

        public virtual Task<Coupon> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions, cancellationToken);
        }

        public virtual Coupon Get(string couponId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions);
        }

        public virtual Task<Coupon> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Coupon> List(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/coupons", requestOptions, options);
        }

        public virtual Task<StripeList<Coupon>> ListAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/coupons", requestOptions, cancellationToken, options);
        }

        public virtual Coupon Update(string couponId, CouponUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions, options);
        }

        public virtual Task<Coupon> UpdateAsync(string couponId, CouponUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/coupons/{couponId}", requestOptions, cancellationToken, options);
        }
    }
}
