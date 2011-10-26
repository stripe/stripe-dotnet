using System;

namespace Stripe
{
    public class StripeDiscount
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("start")]
        public DateTime? Start { get; set; }

        [StripeArgument("end")]
        public DateTime? End { get; set; }

        public StripeCoupon StripeCoupon { get; set; }
    }
}
