using System.Collections.Generic;

namespace Stripe
{
	public class StripeCouponService : StripeService
	{
		public StripeCouponService(string apiKey = null)
			: base(apiKey) { }

		public virtual StripeCoupon Create(StripeCouponCreateOptions createOptions)
		{
			var url = this.ApplyAllParameters(createOptions, Urls.Coupons);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public virtual StripeCoupon Get(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public virtual void Delete(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeCoupon> List(StripeListOptions listOptions = null)
		{
			var url = Urls.Coupons;

			if (listOptions != null)
				url = this.ApplyAllParameters(listOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCoupon>.MapCollectionFromJson(response);
		}
	}
}