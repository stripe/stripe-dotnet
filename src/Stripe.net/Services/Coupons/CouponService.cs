namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CouponService : StripeService,
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

        public virtual Coupon Create(CouponCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Coupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Coupon Update(string couponId, CouponUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Coupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Coupon Get(string couponId, RequestOptions requestOptions = null)
        {
            return Mapper<Coupon>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Coupon Delete(string couponId, RequestOptions requestOptions = null)
        {
            return Mapper<Coupon>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Coupon> List(CouponListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Coupon>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Coupon> CreateAsync(CouponCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Coupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Coupon> UpdateAsync(string couponId, CouponUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Coupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Coupon> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Coupon>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Coupon> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Coupon>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Coupon>> ListAsync(CouponListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Coupon>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
