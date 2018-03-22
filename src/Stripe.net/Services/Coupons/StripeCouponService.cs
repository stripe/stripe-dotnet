using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;
using System.Net;

namespace Stripe
{
    public class StripeCouponService : StripeService
    {
        public StripeCouponService() : base(null) { }
        public StripeCouponService(string apiKey) : base(apiKey) { }



        //Sync
        public virtual StripeCoupon Create(StripeCouponCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCoupon Update(string couponId, StripeCouponUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCoupon Get(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeCoupon> List(StripeCouponListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeCoupon> CreateAsync(StripeCouponCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCoupon> UpdateAsync(string couponId, StripeCouponUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCoupon> GetAsync(string couponId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string couponId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(this.ApplyAllParameters(null, $"{Urls.Coupons}/{WebUtility.UrlEncode(couponId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeCoupon>> ListAsync(StripeCouponListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCoupon>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
