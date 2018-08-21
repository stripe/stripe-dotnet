namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CouponService : StripeService
    {
        public CouponService()
            : base(null)
        {
        }

        public CouponService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeCoupon Create(CouponCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Update(string couponId, CouponUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Get(string couponId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Delete(string couponId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeCoupon> List(CouponListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeCoupon> CreateAsync(CouponCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> UpdateAsync(string couponId, CouponUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> GetAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> DeleteAsync(string couponId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeCoupon>> ListAsync(CouponListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
