using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_used_with_api_key
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService("[your api key here]");
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            StripeCard = StripeCharge.StripeCard;
        };

        Behaves_like<charge_behaviors> behaviors;
    }
}
