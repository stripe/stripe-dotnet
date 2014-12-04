using System.Collections.Generic;
using System.Threading.Tasks;

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

        public virtual async Task<StripeCoupon> CreateAsync(StripeCouponCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Coupons, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }

        public virtual StripeCoupon Get(string couponId)
        {
            var url = FormatGetUrl(couponId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }

        public virtual async Task<StripeCoupon> GetAsync(string couponId)
        {
            var url = FormatGetUrl(couponId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapFromJson(response);
        }

        public virtual void Delete(string couponId)
        {
            var url = FormatDeleteUrl(couponId);

            Requestor.Delete(url, ApiKey);
        }
        
        public virtual async Task DeleteAsync(string couponId)
        {
            var url = FormatDeleteUrl(couponId);

            await Requestor.DeleteAsync(url, ApiKey);
        }

        public virtual IEnumerable<StripeCoupon> List(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCoupon>.MapCollectionFromJson(response);
        }

        public virtual async Task<IEnumerable<StripeCoupon>> ListAsync(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCoupon>.MapCollectionFromJson(response);
        }

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