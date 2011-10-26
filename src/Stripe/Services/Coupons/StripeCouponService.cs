using System.Collections.Generic;
using System.Linq;

namespace Stripe
{
    public class StripeCouponService
    {
        public StripeCoupon Create(StripeCouponCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Coupons);
            
            var response = Requestor.PostString(url);

            return PopulateStripeCoupon(response);
        }

        public StripeCoupon Get(string couponId)
        {
            var url = string.Format("{0}/{1}", Urls.Coupons, couponId);

            var response = Requestor.GetString(url);

            return PopulateStripeCoupon(response);
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

            var json = Mapper<StripeCoupon>.MapCollectionToObjectList(response);

            return json.Select(PopulateStripeCoupon);
        }

        private StripeCoupon PopulateStripeCoupon(string json)
        {
            return Mapper<StripeCoupon>.MapFromJson(json);
        }
    }
}