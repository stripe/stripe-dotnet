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
        {
        }

        public CouponService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/coupons";

        /// <summary>
        /// <p>You can create coupons easily via the <a
        /// href="https://dashboard.stripe.com/coupons">coupon management</a> page of the Stripe
        /// dashboard. Coupon creation is also accessible via the API if you need to create coupons
        /// on the fly.</p>.
        ///
        /// <p>A coupon has either a <c>percent_off</c> or an <c>amount_off</c> and <c>currency</c>.
        /// If you set an <c>amount_off</c>, that amount will be subtracted from any invoice’s
        /// subtotal. For example, an invoice with a subtotal of <currency>100</currency> will have
        /// a final total of <currency>0</currency> if a coupon with an <c>amount_off</c> of
        /// <amount>200</amount> is applied to it and an invoice with a subtotal of
        /// <currency>300</currency> will have a final total of <currency>100</currency> if a coupon
        /// with an <c>amount_off</c> of <amount>200</amount> is applied to it.</p>.
        /// </summary>
        public virtual Coupon Create(CouponCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Post, $"/v1/coupons", options, requestOptions);
        }

        /// <summary>
        /// <p>You can create coupons easily via the <a
        /// href="https://dashboard.stripe.com/coupons">coupon management</a> page of the Stripe
        /// dashboard. Coupon creation is also accessible via the API if you need to create coupons
        /// on the fly.</p>.
        ///
        /// <p>A coupon has either a <c>percent_off</c> or an <c>amount_off</c> and <c>currency</c>.
        /// If you set an <c>amount_off</c>, that amount will be subtracted from any invoice’s
        /// subtotal. For example, an invoice with a subtotal of <currency>100</currency> will have
        /// a final total of <currency>0</currency> if a coupon with an <c>amount_off</c> of
        /// <amount>200</amount> is applied to it and an invoice with a subtotal of
        /// <currency>300</currency> will have a final total of <currency>100</currency> if a coupon
        /// with an <c>amount_off</c> of <amount>200</amount> is applied to it.</p>.
        /// </summary>
        public virtual Task<Coupon> CreateAsync(CouponCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Post, $"/v1/coupons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can delete coupons via the <a href="https://dashboard.stripe.com/coupons">coupon
        /// management</a> page of the Stripe dashboard. However, deleting a coupon does not affect
        /// any customers who have already applied the coupon; it means that new customers can’t
        /// redeem the coupon. You can also delete coupons via the API.</p>.
        /// </summary>
        public virtual Coupon Delete(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Delete, $"/v1/coupons/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>You can delete coupons via the <a href="https://dashboard.stripe.com/coupons">coupon
        /// management</a> page of the Stripe dashboard. However, deleting a coupon does not affect
        /// any customers who have already applied the coupon; it means that new customers can’t
        /// redeem the coupon. You can also delete coupons via the API.</p>.
        /// </summary>
        public virtual Task<Coupon> DeleteAsync(string id, CouponDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Delete, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the coupon with the given ID.</p>.
        /// </summary>
        public virtual Coupon Get(string id, CouponGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Get, $"/v1/coupons/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the coupon with the given ID.</p>.
        /// </summary>
        public virtual Task<Coupon> GetAsync(string id, CouponGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Get, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your coupons.</p>.
        /// </summary>
        public virtual StripeList<Coupon> List(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Coupon>>(HttpMethod.Get, $"/v1/coupons", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your coupons.</p>.
        /// </summary>
        public virtual Task<StripeList<Coupon>> ListAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Coupon>>(HttpMethod.Get, $"/v1/coupons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your coupons.</p>.
        /// </summary>
        public virtual IEnumerable<Coupon> ListAutoPaging(CouponListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Coupon>($"/v1/coupons", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your coupons.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Coupon> ListAutoPagingAsync(CouponListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Coupon>($"/v1/coupons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the metadata of a coupon. Other coupon details (currency, duration,
        /// amount_off) are, by design, not editable.</p>.
        /// </summary>
        public virtual Coupon Update(string id, CouponUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Coupon>(HttpMethod.Post, $"/v1/coupons/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the metadata of a coupon. Other coupon details (currency, duration,
        /// amount_off) are, by design, not editable.</p>.
        /// </summary>
        public virtual Task<Coupon> UpdateAsync(string id, CouponUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Coupon>(HttpMethod.Post, $"/v1/coupons/{id}", options, requestOptions, cancellationToken);
        }
    }
}
