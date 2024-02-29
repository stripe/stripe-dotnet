// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/coupons";

        public virtual Coupon Create(CouponCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Post, $"/v1/coupons", options, requestOptions);
        }

        public virtual Task<Coupon> CreateAsync(CouponCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Post, $"/v1/coupons", options, requestOptions, cancellationToken);
        }

        public virtual Coupon Delete(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Delete, $"/v1/coupons/{id}", options, requestOptions);
        }

        public virtual Task<Coupon> DeleteAsync(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Delete, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Coupon Get(string id, CouponGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Get, $"/v1/coupons/{id}", options, requestOptions);
        }

        public virtual Task<Coupon> GetAsync(string id, CouponGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Get, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Coupon> List(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Coupon>>(HttpMethod.Get, $"/v1/coupons", options, requestOptions);
        }

        public virtual Task<StripeList<Coupon>> ListAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Coupon>>(HttpMethod.Get, $"/v1/coupons", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Coupon> ListAutoPaging(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Coupon>($"/v1/coupons", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Coupon> ListAutoPagingAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Coupon>($"/v1/coupons", options, requestOptions, cancellationToken);
        }

        public virtual Coupon Update(string id, CouponUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Post, $"/v1/coupons/{id}", options, requestOptions);
        }

        public virtual Task<Coupon> UpdateAsync(string id, CouponUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Post, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }
    }
}
