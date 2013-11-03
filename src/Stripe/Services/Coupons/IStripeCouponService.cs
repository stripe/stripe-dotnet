using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeCouponService
    {
        StripeCoupon Create(StripeCouponCreateOptions createOptions);
        StripeCoupon Get(string couponId);
        void Delete(string couponId);
        IEnumerable<StripeCoupon> List(int count = 10, int offset = 0);
    }
}