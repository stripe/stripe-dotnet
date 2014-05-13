using System.Collections.Generic;

namespace Stripe
{
	public class StripeCouponService
	{
		private string ApiKey { get; set; }

		public StripeCouponService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeCoupon> Create(StripeCouponCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Coupons);
		    return url.PostResponse<StripeCoupon>(ApiKey);
		}

        public virtual StripeResponse<StripeCoupon> Get(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);
		    return url.GetResponse<StripeCoupon>(ApiKey);
		}

		public virtual void Delete(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);
		    url.DeleteResponse<StripeCoupon>(ApiKey);
		}

		public virtual StripeResponse<List<StripeCoupon>> List(StripeListOptions listOptions = null)
		{
			var url = Urls.Coupons;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeCoupon>(ApiKey);
		}
	}
}