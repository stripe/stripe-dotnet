namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeCouponService : StripeService
    {
        public StripeCouponService()
            : base(null)
        {
        }

        public StripeCouponService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeCoupon Create(StripeCouponCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Update(string couponId, StripeCouponUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Get(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCoupon Delete(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeCoupon> List(StripeCouponListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeCoupon> CreateAsync(StripeCouponCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> UpdateAsync(string couponId, StripeCouponUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> GetAsync(string couponId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCoupon> DeleteAsync(string couponId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeCoupon>> ListAsync(StripeCouponListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
