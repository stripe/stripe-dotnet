using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_customer_create_options
    {
        public static StripeCustomerCreateOptions ValidCard(string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
        {
            var cardOptions = new StripeSourceOptions()
            {
                Object = "card",
                AddressCountry = "US",
                AddressLine1 = "234 Bacon St",
                AddressLine2 = "Apt 1",
                AddressState = "NC",
                AddressZip = "27617",
                Cvc = "1661",
                ExpirationMonth = "10",
                ExpirationYear = "2021",
                Name = "Johnny Tenderloin",
                Number = "4242424242424242",
            };

            var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
            {
                Source = cardOptions,
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

            return stripeCustomerCreateOptions;
        }

        public static StripeCustomerCreateOptions ValidCardButChargeFails(string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
        {
            var stripeCustomerCreateOptions = ValidCard(_planId, _couponId, _trialEnd);
            stripeCustomerCreateOptions.Source.Number = "4000000000000341";

            return stripeCustomerCreateOptions;
        }

        public static StripeCustomerCreateOptions ValidToken(string tokenId, string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
        {
            var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
            {
                Source = new StripeSourceOptions() { TokenId = tokenId }
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
