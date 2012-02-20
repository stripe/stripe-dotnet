using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public interface IStripeCouponService 
    {
        StripeCoupon Create(StripeCouponCreateOptions createOptions);
        StripeCoupon Get(string couponId);
        void Delete(string couponId);
        IEnumerable<StripeCoupon> List(int count = 10, int offset = 0);
    }

    public class StripeCouponService : IStripeCouponService 
    {
		public StripeCoupon Create(StripeCouponCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Coupons);

			var response = Requestor.PostString(url);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public StripeCoupon Get(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			var response = Requestor.GetString(url);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public void Delete(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			Requestor.Delete(url);
		}

		public IEnumerable<StripeCoupon> List(int count = 10, int offset = 0)
		{
			var url = Urls.Coupons;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			var response = Requestor.GetString(url);

			return Mapper<StripeCoupon>.MapCollectionFromJson(response);
		}
    }
}