using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_customer_create_options
    {
        public static StripeCustomerCreateOptions ValidCard(string _planId = null, string _couponId = null, DateTime? _trialEnd = null, bool _trialEndNow = false)
        {
            var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
            {
                SourceToken = "tok_visa",
                Email = "pork@email.com",
                Description = "Johnny Tenderloin (pork@email.com)",
                AccountBalance = 100,
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            if (_planId != null)
                stripeCustomerCreateOptions.PlanId = _planId;

            if (_couponId != null)
                stripeCustomerCreateOptions.CouponId = _couponId;

            if (_trialEnd != null)
                stripeCustomerCreateOptions.TrialEnd = _trialEnd;

            if (_trialEndNow)
                stripeCustomerCreateOptions.EndTrialNow = true;

            return stripeCustomerCreateOptions;
        }

        public static StripeCustomerCreateOptions ValidCardButChargeFails(string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
        {
            var stripeCustomerCreateOptions = ValidCard(_planId, _couponId, _trialEnd);
            stripeCustomerCreateOptions.SourceToken = "tok_chargeCustomerFail";

            return stripeCustomerCreateOptions;
        }

        public static StripeCustomerCreateOptions ValidToken(string tokenId, string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
        {
            var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
            {
                SourceToken = tokenId
            };

            if (_planId != null)
                stripeCustomerCreateOptions.PlanId = _planId;

            if (_couponId != null)
                stripeCustomerCreateOptions.CouponId = _couponId;

            if (_trialEnd != null)
                stripeCustomerCreateOptions.TrialEnd = _trialEnd;

            return stripeCustomerCreateOptions;
        }
    }
}
