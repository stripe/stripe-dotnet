using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeCouponService : StripeServiceBase
    {
		public StripeCouponService() : base() { }
		public StripeCouponService(bool liveMode) : base(liveMode) { }

		public StripeCoupon Create(StripeCouponCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Coupons);

			var response = Requestor.PostString(url, LiveMode);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public StripeCoupon Get(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			var response = Requestor.GetString(url, LiveMode);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public void Delete(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			Requestor.Delete(url, LiveMode);
		}

		public IEnumerable<StripeCoupon> List(int count = 10, int offset = 0)
		{
			var url = Urls.Coupons;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			var response = Requestor.GetString(url, LiveMode);

			return Mapper<StripeCoupon>.MapCollectionFromJson(response);
		}
    }
}