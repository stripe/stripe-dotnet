using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeCouponService : StripeService
    {
        public StripeCouponService(string apiKey = null) : base(apiKey) { }

        public virtual StripeCoupon Create(StripeCouponCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Coupons, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCoupon> CreateAsync(StripeCouponCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Coupons, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }
#endif

        public virtual StripeCoupon Get(string couponId)
        {
            var url = FormatGetUrl(couponId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCoupon> GetAsync(string couponId)
        {
            var url = FormatGetUrl(couponId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }
#endif

        public virtual void Delete(string couponId)
        {
            var url = FormatDeleteUrl(couponId);

            Requestor.Delete(url, ApiKey);
        }
        
#if NET40
        public virtual async Task DeleteAsync(string couponId)
        {
            var url = FormatDeleteUrl(couponId);

            await Requestor.DeleteAsync(url, ApiKey);
        }
#endif

        public virtual IEnumerable<StripeCoupon> List(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCoupon>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeCoupon>> ListAsync(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(StripeListOptions listOptions)
        {
            var url = Urls.Coupons;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatDeleteUrl(string couponId)
        {
            var url = string.Format("{0}/{1}", Urls.Coupons, couponId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatGetUrl(string couponId)
        {
            var url = string.Format("{0}/{1}", Urls.Coupons, couponId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }
    }
}