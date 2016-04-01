using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCouponService : StripeService
    {
        public StripeCouponService(string apiKey = null) : base(apiKey) { }

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
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCoupon Get(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string couponId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions));
        }

        public virtual IEnumerable<StripeCoupon> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeCoupon> CreateAsync(StripeCouponCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Coupons, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCoupon> UpdateAsync(string couponId, StripeCouponUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCoupon> GetAsync(string couponId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async void DeleteAsync(string couponId, StripeRequestOptions requestOptions = null)
        {
            await Requestor.DeleteAsync(this.ApplyAllParameters(null, $"{Urls.Coupons}/{couponId}", false),
                SetupRequestOptions(requestOptions));
        }

        public virtual async Task<IEnumerable<StripeCoupon>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCoupon>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Coupons, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
