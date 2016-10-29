using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_list_options
    {
        public static StripeChargeListOptions ChargesSinceYesterday()
        {
            return new StripeChargeListOptions
            {
                Created = new StripeDateFilter
                {
                    GreaterThan = DateTime.Now.AddDays(-1)
                }
            };
        }
    }
}