using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeCouponService : BaseStripeService
	{
		public StripeCouponService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeCoupon> Create(StripeCouponCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Coupons, data, ApiKey);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public virtual async Task<StripeCoupon> Get(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCoupon>.MapFromJson(response);
		}

		public virtual async Task Delete(string couponId)
		{
			var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

		public virtual async Task<List<StripeCoupon>> List(int count = 10, int offset = 0)
		{
		    var url = ParameterBuilder.ApplyDataToUrl(Urls.Coupons, new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    });

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCoupon>.MapCollectionFromJson(response);
		}
	}
}